using System.ComponentModel.DataAnnotations;

namespace midTerm.Models.Models.Questions
{
    public class QuestionUpdateModel
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Desc is required")]
        public string Description { get; set; }
    }

}
