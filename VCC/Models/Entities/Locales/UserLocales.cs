using System;
namespace VCC.Models.Entities.Locales
{
	public class UserLocales
	{
		public Guid id { get; set; }
		public string Name { get; set; } = "";
		public bool isActive { get; set; } = true;
    }
}

