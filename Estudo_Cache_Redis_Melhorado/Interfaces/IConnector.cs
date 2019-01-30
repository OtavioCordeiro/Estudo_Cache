using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Cache_Redis_Melhorado.Interfaces
{
    public interface IConnector
    {
        IDatabase GetDataBase();
    }
}
