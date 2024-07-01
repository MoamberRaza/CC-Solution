
namespace VCC.Models.Entities.Skills
{
    public class UsersInSkills
    {
        public UserInfo Users { get; set; } = UserInfo.UserIdInstance;
        public int Level { get; set; } = 1;
        public Guid? ProfileId { get; set; } = null;
    }
}

