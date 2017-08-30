using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FakeData
{
    public static class NetworkData
    {
        private static Random _rnd=new Random();
        private static List<string> _maleMailAddresses = new List<string>();
        private static List<string> _femaleMailAddresses = new List<string>();

        private static List<string> PrepareEmailForMale(string domen)
        {
            for (int i = 0; i < 20; i++)
            {
                string mail = NameData.GetMaleFirstName() + "." + NameData.GetMaleSurname() + "@" + domen;
                _maleMailAddresses.Add(mail);
            }

            return _maleMailAddresses;
            
        }

        private static List<string> PrepareEmailForFemale(string domen)
        {
            for (int i = 0; i < 20; i++)
            {
                string mail = NameData.GetFemaleFirstName() + "." + NameData.GetFemaleSurname() + "@" + domen;
                _maleMailAddresses.Add(mail);
            }

            return _maleMailAddresses;

        }


        private static string Get(List<string> list)
        {
            int number = _rnd.Next(list.Count - 1);
            return list[number];
        }

        public static string GetMaleMailAddress(string domen)
        {
            return Get(PrepareEmailForMale(domen));
        }

        public static string GetFemaleMailAddress(string domen)
        {
            return Get(PrepareEmailForFemale(domen));
        }
    }
}
