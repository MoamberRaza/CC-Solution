// it is work like a tab
using VCC.Models.Entities.RolesGen.Agent;

namespace VCC.Models.Entities.RolesGen
{
    public class AvailableRoles
    {
        public AgentRole AgentRole { get; set; } = new AgentRole();
        public SupervisorRole? SupervisorRoles { get; set; } = null;
        public AdministratorRole? AdministratorRoles { get; set; } = null;
        public ReportingRole? ReportingRole { get; set; } = null;
        public ContactRecordManagerRole? ContactRecordManagerRole { get; set; } = null;

    }
}

