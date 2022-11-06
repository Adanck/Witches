using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class ListActivitiesModel
    {
        [DataMember]
        public List<ActivitiesModel> List = new List<ActivitiesModel>();
    }
}
