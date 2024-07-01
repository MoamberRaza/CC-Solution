    namespace VCC.Models.Entities.Locales
{
    public class Language
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
    }
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public List<Language>? Language { get; set; } = null;   

    }
}

