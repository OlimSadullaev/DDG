using Mock_interview.Entities.Enum;

namespace Mock_interview.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public UserRole U_Role { get; set; }
        public string FullName { get; set; }
        public UserLevelRole L_Role { get; set; }
        public string Experience { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
