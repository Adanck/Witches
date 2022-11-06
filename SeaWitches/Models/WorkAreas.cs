using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class WorkAreas
    {
        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public string? Description { get; set; }
    }
}
