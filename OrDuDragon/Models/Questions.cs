using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrDuDragon.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Enoncer { get; set; }

        public string Reponce1 { get; set; }
        public string Reponce2 { get; set; }
        public string Reponce3 { get; set; }
        public string Reponce4 { get; set; }

        public int BonneReponce { get; set; }
    }

    public class Questions
    {
    }
}