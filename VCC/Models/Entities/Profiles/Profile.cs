using System;
using VCC.Models.Entities.RolesGen;
using VCC.Models.Entities.Media;

// Profile can assign to user profile
namespace VCC.Models.Entities.Profiles
{
    public class Profile
    {
        public Guid Id { get; set; }
        public GeneralInProfile General { get; set; } = new GeneralInProfile();
        public List<AvailableRoles> Roles { get; set; } = new List<AvailableRoles>();
        public MediaType MediaType { get; set; } = new MediaType();
        public List<SkillsInProfile> Skills { get; set; } = new List<SkillsInProfile>();
    }
}

