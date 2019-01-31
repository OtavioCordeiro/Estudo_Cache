using Estudo_Cache_Abstracao;
using Estudo_Cache_Abstracao.Interfaces;
using Estudo_Cache_Redis_Melhorado;
using Estudo_Cache_Redis_Melhorado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppCacheMelhorado
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "localhost:6379";

            IConnector connector = new RedisConnector(connectionString);
            ISerializer serializer = new MySerializer();

            ICache rediCache = new RedisCache(connector, serializer);

            var cacheWrapper = new CacheWrapper(rediCache);

            var cache = new CacheTimeWrapper(cacheWrapper);

            Api api = new Api(cache);

            for (int i = 0; i < 10; i++)
            {
                var result = api.GetInformation();

                Thread.Sleep(5000);

                string value = serializer.Serializer(result);
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
