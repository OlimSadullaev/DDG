namespace Mock_interview.Entities
{
    public class UserInterviewer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int InterviewerId { get; set; }
        public Interviewer Interviewer { get; set; }
    }
}
