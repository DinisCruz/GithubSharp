using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GithubSharp.Core.Models.Internal
{
    [DataContract]
    public class NetworkChunkContainer
    {
        [DataMember(Name = "commits")]
        public IEnumerable<NetworkChunk> Commits { get; set; }
    }
}
