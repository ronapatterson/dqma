using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DQMA.Models;
using DQMA.Infrastructure.Extensions;
using DQMA.Infrastructure.Database;
using DQMA.Infrastructure;
using DQMA.Data;
using DQMA.Controllers.DtoMapping;

using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using GoogleMaps.LocationServices;
using System.Net;
using System.Data;
using System.Text;

namespace DQMA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatementController : Controller
    {
        private readonly static string SUBSCRIPTION_KEY = "304d5373d5a14d6fbf4b92203ea53369"; //"3cafed7d60854422b23835d57a4a8a52";
        private readonly static string ENDPOINT = "https://jcfocr.cognitiveservices.azure.com/"; //"https://jcftest.cognitiveservices.azure.com/";
        private readonly static string URI_BASE = ENDPOINT + "/vision/v3.1/read/analyze";

        private readonly static string GOOGLE_API_KEY = "AIzaSyBgk55xCG1UOQNptcL-7PJ2sOieuxpbTdo";

        private readonly IDatabaseService _dbService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;

        public StatementController(UserManager<IdentityUser> userManager, IDatabaseService dbService, 
            ApplicationDbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            _userManager = userManager;
            _dbService = dbService;
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
        }

        #region SQL Queries
        private static string _getStatementsSql = @"SELECT 
                Cast(s.IncidentDate as SmallDateTIme) IncidentDate,
                d.DivisionName,
                ot.OffenseName,
                s.FullName VictimName,
                c.CountryName VictimCountry,
                m.MotiveName Motive,
                s.Status
            FROM Statements s
            INNER JOIN Countries c ON c.Id = s.CountryId 
            INNER JOIN Divisions d ON d.Id = s.DivisionId
            INNER JOIN OffenseType ot ON ot.Id = s.OffenseTypeId
            LEFT OUTER JOIN Motives m ON m.Id = s.MotiveId;";
        #endregion

        [HttpGet]        
        public async Task<ActionResult> GetAll()
        {
            var parameters = new Dictionary<string, object>();

            var statements = await _dbService.GetDBLocalData(_getStatementsSql, parameters);
            return Ok(statements.ToList<Dto.StatementDto>());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var statement = await _dbContext.Statements.Where(x => x.Id == id && x.DeletedAt != null).ToListAsync();
            return Ok(statement);
        }

        [HttpGet("category")]
        public async Task<IActionResult> GetCatgeory()
        {
            var categories = await _dbContext.CategoryTypes.Select(x => x).ToListAsync();
            if (!categories.Any()) return NotFound();

            return Ok(categories);
        }

        [HttpGet("offense")]
        public async Task<IActionResult> GetOffense()
        {
            var offenses = await _dbContext.OffenseTypes.Select(x => x).ToListAsync();
            if (!offenses.Any()) return NotFound();

            return Ok(offenses);
        }

        [HttpGet("division")]
        public async Task<IActionResult> GetDivision()
        {
            var divisions = await _dbContext.Divisions.Select(x => x).ToListAsync();
            if (!divisions.Any()) return NotFound();

            return Ok(divisions);
        }

        [HttpGet("parish")]
        public async Task<IActionResult> GetParish()
        {
            var parishes = await _dbContext.Parishes.Select(x => x).ToListAsync();
            if (!parishes.Any()) return NotFound();

            return Ok(parishes);
        }

        [HttpGet("motive")]
        public async Task<IActionResult> GetMotive()
        {
            var motives = await _dbContext.Motives.Select(x => x).ToListAsync();
            if (!motives.Any()) return NotFound();

            return Ok(motives);
        }

        [HttpGet("country")]
        public async Task<IActionResult> GetCountry()
        {
            var countries = await _dbContext.Countries.Select(x => x).ToListAsync();
            if (!countries.Any()) return NotFound();

            return Ok(countries);
        }

        [HttpGet("gps/{address}")]
        public async Task<IActionResult> GetGps(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return UnprocessableEntity();

            string url = "https://maps.google.com/maps/api/geocode/xml?address=" + address + "&key=" + GOOGLE_API_KEY;
            WebRequest request = WebRequest.Create(url);

            DataTable dtCoordinates = new DataTable();

            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    
                    dtCoordinates.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                    new DataColumn("Address", typeof(string)),
                    new DataColumn("Latitude",typeof(string)),
                    new DataColumn("Longitude",typeof(string)) });
                    foreach (DataRow row in dsResult.Tables["result"].Rows)
                    {
                        string geometry_id = dsResult.Tables["geometry"].Select("result_id = " + row["result_id"].ToString())[0]["geometry_id"].ToString();
                        DataRow location = dsResult.Tables["location"].Select("geometry_id = " + geometry_id)[0];
                        dtCoordinates.Rows.Add(row["result_id"], row["formatted_address"], location["lat"], location["lng"]);
                    }
                }
            }

            var latitude = dtCoordinates.Rows[0]["Latitude"];
            var longitude = dtCoordinates.Rows[0]["Longitude"];

            return Ok(new { lat = latitude, lon = longitude }) ; 
        }

        [HttpPost]
        public async Task<IActionResult> Create(Dto.CreateStatementDto dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier);

            var statement = new Statement()
            {
                FullName = dto.FullName,
                CategoryTypeId = dto.CategoryTypeId,
                MotiveId = dto.MotiveId,
                OffenseTypeId = dto.OffenseTypeId,
                Address = dto.Address,
                Phone = dto.Phone,
                DivisionId = dto.DivisionId,
                IncidentDate = dto.IncidentDate,
                ParishId = dto.ParishId,
                CountryId = dto.CountryId,
                SuspectDescription = dto.SuspectDescription,
                ScannedText = dto.ScannedText,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                CreatedAt = DateTime.Now,
                CreatedBy = userId.Value,
                Status = "Pending",
                StatusDate = DateTime.Now
            };

            _dbContext.Statements.Add(statement);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = statement.Id }, statement);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Dto.UpdateStatementDto dto)
        {
            var statementInfo = await _dbContext.Statements.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();
            if (statementInfo.DeletedAt != null) return NotFound();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier);

            statementInfo.FullName = dto.FullName;
            statementInfo.IncidentDate = dto.IncidentDate;
            statementInfo.Address = dto.Address;
            statementInfo.CountryId = dto.CountryId;
            statementInfo.OffenseTypeId = dto.OffenseTypeId;
            statementInfo.Latitude = dto.Latitude;
            statementInfo.Longitude = dto.Longitude;
            statementInfo.ParishId = dto.ParishId;
            statementInfo.Phone = dto.Phone;
            statementInfo.DivisionId = dto.DivisionId;
            statementInfo.SuspectDescription = dto.SuspectDescription;
            statementInfo.ScannedText = dto.ScannedText;
            statementInfo.ModifiedAt = DateTime.Now;
            statementInfo.ModifiedBy = userId.Value;
            statementInfo.Status = dto.Status;
            statementInfo.StatusDate = DateTime.Now;
    
            _dbContext.Update(statementInfo);
            await _dbContext.SaveChangesAsync();

            return Ok(statementInfo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var statementInfo = await _dbContext.Statements.FirstOrDefaultAsync(x => x.Id == id);
            statementInfo.DeletedAt = DateTime.Now;

            _dbContext.Update(statementInfo);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("uploadimage")]
        public async Task<IActionResult> UploadImage()
        {            
            var file = HttpContext.Request.Form.Files["UploadedImage"];
            if (file == null) return UnprocessableEntity();

            //var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

            var rootPath = _hostEnvironment.WebRootPath;

            var pathToSave = Path.Combine(rootPath, "img", "uploads");

            var extension = Path.GetExtension(file.FileName);
            if (!extension.IsValidImageFile()) return UnprocessableEntity();

            var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var imagePath = Path.Combine(pathToSave, fileName);

            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            var ocr = await ReadText(imagePath);
            var returnPath = "/img/uploads/" + file.FileName;

            return Ok(ocr.ToStatementOcrDto(returnPath));
        }

        public async Task<OcrResult> ReadText(string imageFilePath)
        {
            //https://gunnarpeipman.com/computer-vision-ocr/ //useful for highlighting areas on scanned images

            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", SUBSCRIPTION_KEY);

            string url = URI_BASE;

            HttpResponseMessage response;

            // Two REST API methods are required to extract text.
            // One method to submit the image for processing, the other method
            // to retrieve the text found in the image.

            // operationLocation stores the URI of the second REST API method,
            // returned by the first REST API method.
            string operationLocation = null;

            // Reads the contents of the specified local image
            // into a byte array.
            byte[] byteData = await GetImageAsByteArray(imageFilePath);

            // Adds the byte array as an octet stream to the request body.
            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses the "application/octet-stream" content type.
                // The other content types you can use are "application/json"
                // and "multipart/form-data".
                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // The first REST API method, Batch Read, starts
                // the async process to analyze the written text in the image.
                response = await client.PostAsync(url, content);
            }

            // The response header for the Batch Read method contains the URI
            // of the second method, Read Operation Result, which
            // returns the results of the process in the response body.
            // The Batch Read operation does not return anything in the response body.
            if (response.IsSuccessStatusCode)
                operationLocation =
                    response.Headers.GetValues("Operation-Location").FirstOrDefault();
            else
            {
                // Display the JSON error data.
                string errorString = await response.Content.ReadAsStringAsync();
                Console.WriteLine("\n\nResponse:\n{0}\n",
                    JToken.Parse(errorString).ToString());
            }

            // If the first REST API method completes successfully, the second 
            // REST API method retrieves the text written in the image.
            //
            // Note: The response may not be immediately available. Text
            // recognition is an asynchronous operation that can take a variable
            // amount of time depending on the length of the text.
            // You may need to wait or retry this operation.
            //
            // This example checks once per second for ten seconds.
            string contentString;
            int i = 0;
            do
            {
                System.Threading.Thread.Sleep(1000);
                response = await client.GetAsync(operationLocation);
                contentString = await response.Content.ReadAsStringAsync();
                ++i;
            }
            while (i < 60 && contentString.IndexOf("\"status\":\"succeeded\"") == -1);

            if (i == 60 && contentString.IndexOf("\"status\":\"succeeded\"") == -1)
            {
                Console.WriteLine("\nTimeout error.\n");
            }

            // Display the JSON response.
            /*Console.WriteLine("\nResponse:\n\n{0}\n",
                JToken.Parse(contentString).ToString());*/

            var result = JsonConvert.DeserializeObject<OcrResult>(contentString);
            return result;
        }

        /// <summary>
        /// Returns the contents of the specified file as a byte array.
        /// </summary>
        /// <param name="imageFilePath">The image file to read.</param>
        /// <returns>The byte array of the image data.</returns>
        private Task<byte[]> GetImageAsByteArray(string imageFilePath)
        {
            return Task.Run(() =>
            {
                // Open a read-only file stream for the specified file.
                using (FileStream fileStream =
                    new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
                {
                    // Read the file's contents into a byte array.
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    return binaryReader.ReadBytes((int)fileStream.Length);
                }
            });            
        }
    }
}
