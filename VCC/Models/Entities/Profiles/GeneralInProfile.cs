using System;
using VCC.Models.Entities.Users;
using VCC.Models.Entities.Locales;

namespace VCC.Models.Entities.Profiles
{
    public class GeneralInProfile
    {
        public string ProfileName { get; set; } = ""; // timezone
        public string ProfileDescription { get; set; } = ""; // timezone
        public List<UserObject> UsersList { get; set; } = new List<UserObject>();
        public List<UserLocales> locales { get; set; } = new List<UserLocales>();
        public string? UserTimeZone { get; set; } = null; // will make it generic


        public static readonly GeneralInProfile ProfileNameInstance = new GeneralInProfile { ProfileName = "ProfileName" };
    }
}

