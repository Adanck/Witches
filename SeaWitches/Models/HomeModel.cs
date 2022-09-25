using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class HomeModel
    {
        [DataMember]
        public string? About { get; set; }

        [DataMember]
        public string? Contact { get; set; }
    }
}
