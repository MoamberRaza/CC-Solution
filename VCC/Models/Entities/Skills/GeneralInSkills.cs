using System;
namespace VCC.Models.Entities.Skills
{
	public class GeneralInSkills
	{
		public string Name { get; set; } = "";
		public string Descriptions { get; set; } = "";
		public string Message { get; set; } = "";



		public static readonly GeneralInSkills NameInstance = new GeneralInSkills { Name = "Name" };
    }
}

