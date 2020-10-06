using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using NguyenIT.Quiz.ViewModels;

namespace NguyenIT.Quiz.Pages
{
    public class QuizModel : DefaultPage
    {
        [BindProperty]
        public int Year { get; set; }
        [BindProperty]
        public int Number { get; set; }
        [BindProperty]
        public int Count { get; set; }
        [BindProperty]
        public List<QuizViewModel> Quizs { get; set; } = new List<QuizViewModel>();
        public void OnGet(int year, int number)
        {
            Year = year;
            Number = number;
            Quizs = LoadJson(year, number).Select(MapTo).ToList();
        }
        private QuizViewModel MapTo(QuestionJson json)
        {
            QuizViewModel quizViewModel = new QuizViewModel();
            quizViewModel.A = json.A;
            quizViewModel.B = json.B;
            quizViewModel.C = json.C;
            quizViewModel.D = json.D;
            quizViewModel.Answer = json.Answer;
            quizViewModel.Question = json.Question;
            quizViewModel.Reason = json.Reason;
            quizViewModel.Id = Count;
            Count++;
            return quizViewModel;
        }
        private List<QuestionJson> LoadJson(int year, int number)
        {
            using (StreamReader r = new StreamReader("wwwroot/data/" + year +"/"+number+".json"))
            {
                string json = r.ReadToEnd();
                List<QuestionJson> items = JsonConvert.DeserializeObject<List<QuestionJson>>(json);
                return items;
            }
        }
    }
    public class QuizViewModel: QuestionJson
    {
        public int Id { get; set; }
    }
}
