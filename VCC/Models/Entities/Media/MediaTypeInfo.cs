namespace VCC.Models.Entities.Media
{
    public enum MediaTypeE { NONE, AID, CHERRY_PICK }
    // Vocie, Email, CHAT can be MEDIA
    public class MediaTypeInfo
    {
        public Guid MediaId { get; set; } // system generated
        public string TimeStamp { get; set; } = ""; // timezone
        public string Name { get; set; } = ""; // Please enter Name
        public bool Status { get; set; } = true; // if available for use
        public Guid? excludedCountryIds { get; set; } = null; // where we are not supporting.
        // VCC other options
        public bool EnableMedia { get; set; } = false;
        public int MaxAllowd { get; set; } = 0; // maximum chat,voice,email can be accepted
        public MediaTypeE MediaType { get; set; } = MediaTypeE.NONE; // AID or CherryPick - None is for no meida type

    }


}

