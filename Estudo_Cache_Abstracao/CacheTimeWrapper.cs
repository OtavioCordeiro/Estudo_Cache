using Estudo_Cache_Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Abstracao
{
    public class CacheTimeWrapper : ICache
    {
        private ICache inner;

        Stopwatch time;

        public CacheTimeWrapper(ICache cache)
        {
            inner = cache;
            time = new Stopwatch();
        }

        public void ClearData(string key)
        {
            time.Restart();
            inner.ClearData(key);
            time.Stop();

            var timeInMilliseconds = time.ElapsedMilliseconds;
        }

        public T GetData<T>(string key)
        {
            time.Restart();
            var result = inner.GetData<T>(key);
            time.Stop();

            var timeInMilliseconds = time.ElapsedMilliseconds;

            return result;
        }

        public void SetData(string key, object data)
        {
            time.Restart();
            inner.SetData(key, data);
            time.Stop();

            var timeInMilliseconds = time.ElapsedMilliseconds;
        }
    }
}
