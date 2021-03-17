using System.ComponentModel.DataAnnotations;

namespace midTerm.Models.Models.Questions
{
    public class QuestionCreateModel
    {

        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Desc is required")]
        public string Description { get; set; }
    }

}
