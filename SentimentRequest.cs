using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{
    public class SentimentRequest
    {
        [JsonProperty(PropertyName = "documents")]
        public List<Document> Documents { get; set; }

    }

    public class Document
    {
        public string id { get; set; }
        public string text { get; set; }
    }
}
