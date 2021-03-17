using System.ComponentModel.DataAnnotations;

namespace midTerm.Models.Models.Options
{
    public class OptionCreateModel
    {
        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Text is required")]
        public int? Order { get; set; }
      
    }
}
