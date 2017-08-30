using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FakeData
{
    public static class NetworkData
    {
        private static Random _rnd;
        private static List<string> _maleMailAddresses = new List<string>();

        private static List<string> PrepareEmail(string domen)
        {
            for (int i = 0; i < 20; i++)
            {
                string mail = NameData.GetMaleFirstName() + "." + NameData.GetMaleSurname() + "@" + domen;
                _maleMailAddresses.Add(mail);
            }

            return _maleMailAddresses;
            
        }

        private static string Get(List<string> list)
        {
            _rnd = new Random();
            int number = _rnd.Next(list.Count - 1);
            return list[number];
        }

        public static string GetMaleMailAddress(string domen)
        {
            return Get(PrepareEmail(domen));
        }
    }
}
