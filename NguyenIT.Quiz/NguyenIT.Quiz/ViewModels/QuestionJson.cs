using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenIT.Quiz.ViewModels
{
    public class QuestionJson
    {
        [JsonProperty("Question")]
        public string Question { get; set; }
        [JsonProperty("a")]
        public string A { get; set; }
        [JsonProperty("b")]
        public string B { get; set; }
        [JsonProperty("c")]
        public string C { get; set; }
        [JsonProperty("d")]
        public string D { get; set; }
        [JsonProperty("answer")]
        public string Answer { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
