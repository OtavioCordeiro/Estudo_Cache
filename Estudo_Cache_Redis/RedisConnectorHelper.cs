using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Redis
{
    public class RedisConnectorHelper
    {
        public Lazy<ConnectionMultiplexer> RedisConnection;

        string configuration = "localhost:6379";

        public RedisConnectorHelper()
        {
            ConfigurationOptions options = ConfigurationOptions.Parse(configuration);
            options.AllowAdmin = true;

            RedisConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(options);
            });
        }

        public IServer GetServer()
        {
            return RedisConnection.Value.GetServer(configuration);
        }
    }
}
