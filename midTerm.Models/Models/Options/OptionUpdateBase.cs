using System.ComponentModel.DataAnnotations;

namespace midTerm.Models.Models.Options
{
    public class OptionUpdateBase
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Text is required")]
        public int? Order { get; set; }
        [Required]
        public int QuestionId { get; set; }
    }
}
