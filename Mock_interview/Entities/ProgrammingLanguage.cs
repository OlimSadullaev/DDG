namespace Mock_interview.Entities
{
    public class ProgrammingLanguage
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }

}
