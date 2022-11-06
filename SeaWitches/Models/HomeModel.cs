using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class HomeModel
    {

        [DataMember]
        public string? Mision { get; set; }

        [DataMember]
        public string? Vision { get; set; }

        [DataMember]
        public string? History { get; set; }

        [DataMember]
        public string? GeneralObjective { get; set; }

        [DataMember]
        public string? OrganizationalStructure { get; set; }

        [DataMember]
        public string? About { get; set; }
    }
}
