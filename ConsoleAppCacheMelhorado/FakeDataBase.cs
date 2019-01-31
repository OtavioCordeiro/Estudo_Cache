using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCacheMelhorado
{
    public class FakeDataBase
    {
        private static int _id = 0;

        public Information GetInformation()
        {
            var information = new Information();

            information.CreateDate = DateTime.Now;
            information.Description = $"Hoje é {DateTime.Now.DayOfWeek.ToString()}";
            information.Id = GetId();

            return information;
        }

        private int GetId()
        {
            return ++_id;
        }
    }
}
