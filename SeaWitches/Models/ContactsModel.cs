using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [Serializable]
    [DataContract]
    public class ContactsModel
    {
        [DataMember]
        public string? Facebook { get; set; }

        [DataMember]
        public string? Instagram { get; set; }

        [DataMember]
        public string? WhatsApp { get; set; }

        [DataMember]
        public string? Telegram { get; set; }

        [DataMember]
        public string? Twitter { get; set; }

        [DataMember]
        public string? Email { get; set; }

        [DataMember]
        public string? Phone1 { get; set; }

        [DataMember]
        public string? Phone2 { get; set; }
    }
}
