using Estudo_Cache_Redis_Melhorado.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Redis_Melhorado
{
    public class RedisConnector : IConnector
    {
        private Lazy<ConnectionMultiplexer> RedisConnection;

        public RedisConnector(string connectionString)
        {
            RedisConnection = new Lazy<ConnectionMultiplexer>(() => { return ConnectionMultiplexer.Connect(connectionString); });
        }

        public IDatabase GetDataBase()
        {
            return RedisConnection.Value.GetDatabase();
        }
    }
}
