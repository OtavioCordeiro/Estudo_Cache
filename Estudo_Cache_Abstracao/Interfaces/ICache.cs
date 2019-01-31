using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Abstracao.Interfaces
{
    public interface ICache
    {
        void SetData(string key, object data);

        T GetData<T>(string key);

        void ClearData(string key);
    }
}
