using System;
namespace VCC.Models.Entities.Campigns
{
    public enum CampaignTypeE
    {
        INBOUND, OUTBOUND
    }
    public class GeneralInCampaign
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        //
        public int VoiceLines { get; set; } = 0;
        public int TextInteractions { get; set; } = 0;
        //
        public CampaignTypeE CampaignType { get; set; } = CampaignTypeE.INBOUND;
        public string CampaignProfile { get; set; } = ""; // will set

        // ONLY AVAILABLE IF TYPE IS INBOUND
        public List<string> OutboundSkill { get; set; } = new List<string>();
        // ONLY AVAILABLE IF TYPE IS OUTBOUND
        public List<string> Skills { get; set; } = new List<string>();
        //CAN BE SYSTEM AND CUSTOM
        public string Dispositions { get; set; } = "";
        //
        public string Connectors { get; set; } = "";
        public string WorkSheet { get; set; } = "";
        // Conference Structures
        public string Conferences { get; set; } = "";



    }
}

