using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Redis
{
    public class CacheSimples
    {
        IDatabase cacheDb;
        private IServer server;
        private string key = "otc";

        public CacheSimples()
        {
            var helper = new RedisConnectorHelper();

            cacheDb = helper.RedisConnection.Value.GetDatabase();

            server = helper.GetServer();
        }

        public void WriteRedisData(string value)
        {
            cacheDb.StringAppend(key, value);
        }

        public string ReadRedisData()
        {
            return cacheDb.StringGet(key);
        }

        public void Clear()
        {
            cacheDb.KeyDelete(key);
        }

        private void ClearDataBase()
        {
            server.FlushDatabase();
        }

        private void ClearAllDataBase()
        {
            server.FlushAllDatabases();
        }
    }
}
