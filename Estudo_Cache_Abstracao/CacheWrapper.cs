using Estudo_Cache_Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Abstracao
{
    public class CacheWrapper : ICache
    {
        private ICache inner;

        public CacheWrapper(ICache cache)
        {
            inner = cache;
        }

        public void SetData(string key, object data)
        {
            if (data != null)
            {
                inner.SetData(key, data);
            }
        }

        public T GetData<T>(string key)
        {
            return inner.GetData<T>(key);
        }

        public void ClearData(string key)
        {
            inner.ClearData(key);
        }
    }
}
