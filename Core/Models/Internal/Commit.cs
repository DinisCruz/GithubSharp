using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GithubSharp.Core.Models.Internal
{
    [DataContract]
    public class CommitListContainer
    {
        [DataMember(Name = "commits")]
        public IEnumerable<Commit> Commits { get; set; }
    }

    [DataContract]
    public class SingleFileCommitContainer
    {
        [DataMember(Name = "commit")]
        public SingleFileCommit Commit { get; set; }
    }
}
