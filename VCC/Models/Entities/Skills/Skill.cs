namespace VCC.Models.Entities.Skills
{
	public class Skill
	{
		public GeneralInSkills General { get; set; } = new GeneralInSkills();
		public List<UsersInSkills> Users { get; set; } = new List<UsersInSkills>();

		//public static readonly UsersInSkills UsersInSkills = new UsersInSkills {};

    }
}

