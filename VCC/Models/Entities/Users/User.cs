// list of user to add in skill or any where this list will render
using VCC.Enums;
namespace VCC.Models.Entities.Users
{

    // this will be shown 
    public class UserColumn
    {
        public UserInfo PropertyName { get; set; }
        public bool CanView { get; set; }

        public UserColumn(UserInfo propertyName, bool canViewColumn)
        {
            PropertyName = propertyName;
            CanView = canViewColumn;
        }
    }

    public class User
    {
        public UserColumn Username { get; set; } = new UserColumn(UserInfo.UsernameInstance,true);
        public UserColumn FirstName { get; set; } = new UserColumn(UserInfo.FirstNameInstance,true);
        public UserColumn LastName { get; set; } = new UserColumn(UserInfo.LastNameInstance, true);
        public List<RolesE> Roles { get; set; } = new List<RolesE> { RolesE.AGENT };  
    }
}

