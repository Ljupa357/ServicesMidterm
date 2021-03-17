using midTerm.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace midTerm.Models.Models.Questions
{
    public class QuestionModelExtended
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
