using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

namespace GithubSharp.Core.Models.Internal
{
    [DataContract]
    public class RepositoryCollection<TRepoType>
    {
        [DataMember(Name = "repositories")]
        public IEnumerable<TRepoType> Repositories { get; set; }
    }

    [DataContract]
    public class RepositoryContainer<TRepoType>
    {
        [DataMember(Name = "repository")]
        public TRepoType Repository { get; set; }
    }

    [DataContract]
    public class RepositoryFromNetworkContainer
    {
        [DataMember(Name = "network")]
        public IEnumerable<Repository> Network { get; set; }
    }

    [DataContract]
    public class RepositoryDelete
    {
        [DataMember(Name = "delete_token")]
        public string DeleteToken { get; set; }
    }

    [DataContract]
    public class RepositoryDeleted
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }
    }

    [DataContract]
    public class LanguagesCollection
    {
        [DataMember(Name = "languages")]
        public Dictionary<string, int> Languages { get; set; }
    }

    [DataContract]
    public class TagCollection
    {
        [DataMember(Name = "tags")]
        public Dictionary<string, string> Tags { get; set; }
    }

    [DataContract]
    public class BranchesCollection
    {
        [DataMember(Name = "branches")]
        public JsonSimpleDictionary Branches { get; set; }
    }
}
