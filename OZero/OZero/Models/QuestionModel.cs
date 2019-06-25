using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZero.Models
{
    public class QuestionModel
    {
        public int QuestionID { get; set; }
        public int EventID { get; set; }
        public string Question { get; set; }
        public int QuestionType { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
    }
}