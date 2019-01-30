using Estudo_Cache_Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Abstracao
{
    public class CacheWrapper
    {
        private ICache _cache;

        public CacheWrapper(ICache cache)
        {
            _cache = cache;
        }

        public void SetData<T>(string key, T data)
        {
            if (data != null)
            {
                _cache.SetData(key, data);
            }
        }

        public T GetData<T>(string key)
        {
            return _cache.GetData<T>(key);
        }

        public void ClearData(string key)
        {
            _cache.ClearData(key);
        }
    }
}
