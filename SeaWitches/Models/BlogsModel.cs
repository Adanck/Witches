using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class BlogsModel
    {
        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public string? Description { get; set; }

        [DataMember]
        public byte[]? Image { get; set; }

        [DataMember]
        public string? Author { get; set; }
    }
}
