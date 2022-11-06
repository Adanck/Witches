using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [Serializable]
    [DataContract]
    public class ListProjectsModel
    {
        [DataMember]
        public List<ProjectsModel> ListProjects { get; set; } = new List<ProjectsModel>();
    }
}
