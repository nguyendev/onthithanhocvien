using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Quiz.data;

namespace Quiz
{
    public class QuizModel : PageModel
    {
        [BindProperty]
        public List<QuestionJson> Questions { get; set; } = new List<QuestionJson>();
        public void OnGet(string year, string number)
        {
            Questions = LoadJson();
        }
        private List<QuestionJson> LoadJson()
        {
            using (StreamReader r = new StreamReader("data/1.json"))
            {
                string json = r.ReadToEnd();
                List<QuestionJson> items = JsonConvert.DeserializeObject<List<QuestionJson>>(json);
                return items;
            }
        }
    }
}
