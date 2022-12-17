namespace Mock_interview.Entities
{
    public class ProgrammingLanguage
    {
        public int ProgrammingLanguageId { get; set; }

        public string ProgrammingLanguageName { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }

}
