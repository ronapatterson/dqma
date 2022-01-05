using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DQMA.Models
{
    public class OcrResult
    {
        public string Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }

        [JsonProperty("analyzeResult")]
        public AnalyzeResult AnalyzeResult { get; set; }
    }

    public class AnalyzeResult
    {
        public string Version { get; set; }

        [JsonProperty("readResults")]
        public IEnumerable<ReadResult> ReadResults { get; set; }
    }

    public class ReadResult
    {
        public int Page { get; set; }
        public int Angle { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Unit { get; set; }   
        public IEnumerable<Line> Lines { get; set; }
    }

    public class Line
    {
        public int[] BoundingBox { get; set; }        
        public string Text { get; set; }
        public IEnumerable<Word> Words { get; set; }
    }

    public class Word
    {
        public int[] BoundingBox { get; set; }
        public string Text { get; set; }
        public double Confidence { get; set; }
    }
}
