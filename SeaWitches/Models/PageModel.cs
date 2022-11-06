using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class PageModel
    {
        [DataMember]
        public HomeModel? Home { get; set; }

        [DataMember]
        public ListActivitiesModel? Activities { get; set; }

        [DataMember]
        public ListBlogModel? Blogs { get; set; }

        [DataMember]
        public ListProjectsModel? Projects { get; set; }

        [DataMember]
        public List<SpecificObjectives>? SpecificObjectives { get; set; }

        [DataMember]
        public ContactsModel? Contacts { get; set; }

        [DataMember]
        public WorkAreas? WorkAreas { get; set; }

        [DataMember]
        public WorkTeam? WorkTeam { get; set; }
    }
}
