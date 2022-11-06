using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class ActivitiesModel
    {
        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public string? Description { get; set; }

        [DataMember]
        public byte[]? Video { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string? Author { get; set; }

    }
}
