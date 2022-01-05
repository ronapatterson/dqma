using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DQMA.Controllers.DtoMapping
{
    public static class StatementDtoMapping
    {
        public static Dto.StatementOCRDto ToStatementOcrDto(this Models.OcrResult ocrResult, string imageUrl)
        {
            var textArray = ocrResult.AnalyzeResult.ReadResults.Select(x => x.Lines.Select(x => x.Text));

            var dto = new Dto.StatementOCRDto()
            {
                ImageUrl = imageUrl,
                Narrative = string.Join(" ", textArray.FirstOrDefault().Select(x => x))
            };

            return dto;
        }
    }
}
