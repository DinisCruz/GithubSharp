using System.Collections.Generic;
using GithubSharp.Core.Services;
using GithubSharp.Core.Models;

namespace GithubSharp.Core.API
{
    public class Network : Base.BaseAPI
    {
        public Network(ICacheProvider CacheProvider, ILogProvider LogProvider) : base(CacheProvider, LogProvider) { }

        public NetworkMeta Meta( string RepositoryName)
        { 
            LogProvider.LogMessage(string.Format("Network.Meta - Username : '{0}', RepositoryName : '{1}'",  RepositoryName));

            var url = string.Format("http://github.com/{0}/{1}/network_meta",  RepositoryName);

            return ConsumeJsonUrl<NetworkMeta>(url);
        }

        public IEnumerable<NetworkChunk> MetaChunks( string RepositoryName, string NetworkHash)
        {
            return MetaChunks( RepositoryName, NetworkHash, -1, -1);
        }

        public IEnumerable<NetworkChunk> MetaChunks( string RepositoryName, string NetworkHash, int Start, int End)
        {
            LogProvider.LogMessage(string.Format("Network.MetaChunks - Username : '{0}', RepositoryName : '{1}', NetworkHash : '{2}', Start : '{3}', End : '{4}'",
                
                RepositoryName,
                NetworkHash,
                Start,
                End));

            var url = string.Format("http://github.com/{0}/{1}/network_data_chunk?nethash={2}{3}",
                
                RepositoryName,
                NetworkHash,
                End > 0 && Start > -1 ?
                    string.Format("?start={0}&end={1}", Start, End) : string.Empty);

            var result = ConsumeJsonUrl<Models.Internal.NetworkChunkContainer>(url);

            return result != null ? result.Commits : null;
        }
    }
}
