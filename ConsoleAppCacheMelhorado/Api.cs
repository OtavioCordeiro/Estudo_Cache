using Estudo_Cache_Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCacheMelhorado
{
    public class Api
    {
        private ICache _cache;
        FakeDataBase database;

        public Api(ICache cache)
        {
            _cache = cache;
            database = new FakeDataBase();
        }

        public Information GetInformation()
        {
            string key = "Information_Key";

            Information information = _cache.GetData<Information>(key);

            if (information is Information isInformation)
                return isInformation;

            information = database.GetInformation();

            _cache.SetData(key, information);

            return information;
        }
    }
}
