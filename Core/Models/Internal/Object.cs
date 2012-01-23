using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GithubSharp.Core.Models.Internal
{
    [DataContract]
    public class ObjectContainer
    {
        [DataMember(Name = "tree")]
        public IEnumerable<Object> Tree { get; set; }
    }

    [DataContract]
    public class BlobContainer
    {
        [DataMember(Name = "blob")]
        public Blob Blob { get; set; }
    }

    [DataContract]
    public class BlobListContainer
    {
        [DataMember(Name = "blobs")]
        public Dictionary<string, string> Blobs { get; set; }
    }
}
