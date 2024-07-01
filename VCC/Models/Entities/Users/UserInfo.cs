using System;
using VCC.Models.Entities.Profiles;

namespace VCC.Models.Entities
{
    public class UserInfo
    {
        public Guid UserId { get; set; } // system generated
        public string Avatar { get; set; } = ""; // url
        public string FirstName { get; set; } = ""; // url
        public string LastName { get; set; } = ""; // url
        public string Extension { get; set; } = ""; // url
        public string Email { get; set; } = ""; // url
        public string Username { get; set; } = ""; // url
        public bool IsActive { get; set; } = true; // url
        public bool CanChangePassword { get; set; } = true; // url
        public bool ShouldChangeAtNextLogin { get; set; } = false; // url
        public string Password { get; set; } = ""; // url
        public string StartDate { get; set; } = ""; // url
        public GeneralInProfile Profile { get; set; } = GeneralInProfile.ProfileNameInstance; // url

        // Static instances to be used as references
        public static readonly UserInfo UserIdInstance = new UserInfo { UserId = Guid.NewGuid() };
        public static readonly UserInfo AvatarInstance = new UserInfo { Avatar = "Avatar URL" };
        public static readonly UserInfo FirstNameInstance = new UserInfo { FirstName = "First Name" };
        public static readonly UserInfo LastNameInstance = new UserInfo { LastName = "Last Name" };
        public static readonly UserInfo ExtensionInstance = new UserInfo { Extension = "Extension" };
        public static readonly UserInfo EmailInstance = new UserInfo { Email = "Email" };
        public static readonly UserInfo UsernameInstance = new UserInfo { Username = "Username" };
        public static readonly UserInfo PasswordInstance = new UserInfo { Password = "Password" };
        public static readonly UserInfo StartDateInstance = new UserInfo { StartDate = "Start Date" };
        public static readonly UserInfo ProfileInstance = new UserInfo { Profile = GeneralInProfile.ProfileNameInstance };
    }




}

