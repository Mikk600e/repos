using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpørgsmålsTing
{
    class Question
    {
        public string Spoergsmaal { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string CorrectAnswer { get; set; }
        public int QuestionNumber { get; set; }

    }
}
