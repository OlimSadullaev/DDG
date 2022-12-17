namespace Mock_interview.Entities
{
    public class Interviewer
    {
        public int InterviewerId { get; set; }
        public int UserId { get; set; }
        public string Projects { get; set; }
        public int AbilityId { get; set; }
        public Ability Ability { get; set;}
        public User User { get; set; }

        public string Projects { get; set; }

        public Ability Ability { get; set; }
    }
}
