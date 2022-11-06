using System.Runtime.Serialization;

namespace SeaWitches.Models
{
    [DataContract]
    [Serializable]
    public class ListBlogModel
    {
        [DataMember]
        public List<BlogsModel> ListBlog { get; set; } = new List<BlogsModel>();
    }
}
