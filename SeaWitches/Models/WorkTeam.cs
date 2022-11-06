using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [Serializable]
    [DataContract]
    public class WorkTeam
    {
        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public string? Description { get; set; }
    }
}
