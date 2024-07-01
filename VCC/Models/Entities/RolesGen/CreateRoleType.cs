// Possible Generic Roles Agents Can Have List of all
namespace VCC.Models.Entities.RolesGen.Agent
{
    public class Option
    {
        public bool IsActive { get; set; }
        public string Name { get; set; }

        public Option(bool isActive, string name)
        {
            IsActive = isActive;
            Name = name;
        }
    }

    public class RoleType
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; } = "";
        public bool hasOptions { get; set; } = false;
        public List<Option> options { get; set; } = new List<Option>();
        public bool IsActive { get; set; } = true;
        // Super Admin related
        public bool Disabled { get; set; } = false; // Top Layer can manage it
        public int? DisabledBy { get; set; } = 0; // Top Layer can manage it
    }

}

