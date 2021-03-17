using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace midTerm.Models.Models.Options
{
    public class OptionModelBase
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int? Order { get; set; }
        [Required]
        public int QuestionId { get; set; }
    }
}
