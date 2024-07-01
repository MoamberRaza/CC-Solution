using System;
namespace VCC.Enums
{
    public enum RolesE
    {
        SUPER_ADMIN,
        MANAGER,
        REPRESENTATIVE,
        //
        ADMINISTRATOR,
        SUPERVISOR,
        AGENT,
        REPORTING,
        CONTACT_RECORD_MANAGER
    }


    public static class RolesEExtensions
    {
        private static readonly Dictionary<RolesE, string> RoleNames = new Dictionary<RolesE, string>
    {
        { RolesE.SUPER_ADMIN, "SUPER_ADMIN" },
        { RolesE.MANAGER, "MANAGER" },
        { RolesE.REPRESENTATIVE, "REPRESENTATIVE" },
        { RolesE.ADMINISTRATOR, "ADMINISTRATOR" },
        { RolesE.SUPERVISOR, "SUPERVISOR" },
        { RolesE.AGENT, "AGENT" },
        { RolesE.REPORTING, "REPORTING" },
        { RolesE.CONTACT_RECORD_MANAGER, "CONTACT_RECORD_MANAGER" }
    };

        public static string ToRoleName(this RolesE role)
        {
            return RoleNames[role];
        }
    }

}

