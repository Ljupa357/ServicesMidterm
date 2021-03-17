using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace midTerm.Models.Models.Questions
{
    public  class QuestionModelBase
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Description { get; set; }
    }

}
