using Estudo_Cache_Abstracao.Interfaces;
using Estudo_Cache_Redis_Melhorado.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Redis_Melhorado
{
    public class RedisCache : ICache
    {
        private IDatabase _dataBase;
        private ISerializer _serializer;

        public RedisCache(IConnector connector, ISerializer serializer)
        {
            _dataBase = connector.GetDataBase(); ;
            _serializer = serializer;
        }

        public void ClearData(string key)
        {
            _dataBase.KeyDelete(key);
        }

        public T GetData<T>(string key)
        {
            var result = _dataBase.StringGet(key);

            if (result.HasValue)
                return _serializer.Deserializer<T>(result.ToString());

            return default(T);
        }

        public void SetData(string key, object data)
        {
            var dataMessage = _serializer.Serializer(data);

            _dataBase.StringSet(key, dataMessage, TimeSpan.FromSeconds(10));
        }
    }
}
