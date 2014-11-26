﻿using Newtonsoft.Json;

namespace TinderApp.Models
{
    public class ProcessedFile
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}