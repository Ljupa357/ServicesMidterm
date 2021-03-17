namespace midTerm.Models.Models.Options
{
    public class OptionModelExtended
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? Order { get; set; }
        public int QuestionId { get; set; }

        
        public virtual Question Question { get; set; }
    }
}
