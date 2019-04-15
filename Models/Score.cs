using System;
using System.ComponentModel.DataAnnotations;

namespace GuessingGame.Models 
{
    public class Score 
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int AnswerScore { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ScoreLog { get; set;}
    }
}