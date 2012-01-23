using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GithubSharp.Core.Models.Internal
{
    [DataContract]
    public class PublicKeyCollection<TPublicKeyType>
    {
        [DataMember(Name = "public_keys")]
        public IEnumerable<TPublicKeyType> PublicKeys { get; set; }
    }

    [DataContract]
    public class UsersCollection<TUserType>
    {
        [DataMember(Name = "users")]
        public IEnumerable<TUserType> Users { get; set; }
    }

    [DataContract]
    public class EmailCollection
    {
        [DataMember(Name = "emails")]
        public IEnumerable<string> Emails { get; set; }
    }

    [DataContract]
    public class UserContainer<TUserType>
    {
        [DataMember(Name = "user")]
        public TUserType User { get; set; }
    }

    [DataContract]
    public class CollaboratorsCollection
    {
        [DataMember(Name = "collaborators")]
        public IEnumerable<string> Collaborators { get; set; }
    }
}
