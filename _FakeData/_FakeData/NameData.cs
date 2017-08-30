using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FakeData
{
    public class NameData
    {
        private static Random _rnd;

        private static List<string> _firstMaleNames = new List<string>()
            {
                "Hüseyn","Orxan","Tural",
                 "Asif","Yusif","Elçin",
                 "Mirzə","Elmar","Nahid",
                  "Məhərrəm","Nicat","Rəşid",
                  "Sənan","Əziz","Elvin",
                  "Əbdül","Elnur","Nurlan",
                  "Namiq","Vahid","Etibar"
            };
        private static List<string> _firstFemaleNames = new List<string>()
        {
                 "Zərifə","Arzu","Nigar",
                 "Şəhla","Günel","Aysel",
                 "Aynur","Nuranə","Günay",
                 "Səbinə","Nuray","Elnurə",
                 "Fəridə","Pərvin","İzzət",
                 "Sevda","Zeynəb","Zülfiyyə",
                 "Lalə","Ruhiyyə","Elnarə"
        };

        private static List<string> _maleSurnames = new List<string>()
        {
            "Mikayılov","Quliyev","Mirzəyev",
            "Cəfərov","Qarayev","Şirəliyev",
            "Əliyev","Yusifli","Bədirli",
            "Rəhimli","Nuriyev","Mehdiyev",
            "Nadirov","Yuniszadə","Sadıqov",
            "Fətəliyev","Nemətzadə","Cəbrayılzadə",
            "Musayev","Hüseynov","Zeynalov"
        };

        private static List<string> _femaleSurnames = new List<string>()
        {
            "Mikayılova","Quliyeva","Mirzəyeva",
            "Cəfərova","Qarayeva","Şirəliyeva",
            "Əliyeva","Yusifli","Bədirli",
            "Rəhimli","Nuriyeva","Mehdiyeva",
            "Nadirova","Yuniszadə","Sadıqova",
            "Fətəliyeva","Nemətzadə","Cəbrayılzadə",
            "Musayeva","Hüseynova","Zeynalova","Nuriyeva"
        };

        private static List<string> _companyName = new List<string>()
        {
            "Azercell","Bakcell","Nar mobile",
            "Connect","GoldenPay","Delta Telecom",
            "Katv","Ailə TV","Sinam",
        };

        private static string Get(List<string> list)
        {
            _rnd = new Random();
            int number = _rnd.Next(list.Count - 1);
            return list[number];
        }

        public static string GetCompanyName()
        {
            return Get(_companyName);
        }
        public static string GetMaleFirstName()
        {
            return Get(_firstMaleNames);
        }

        public static string GetFemaleFirstName()
        {
            return Get(_firstFemaleNames);
        }

        public static string GetMaleSurname()
        {
            return Get(_maleSurnames);
        }
        public static string GetFemaleSurname()
        {
            return Get(_femaleSurnames);
        }

        public static string GetMaleFullName()
        {
            return GetMaleFirstName() + " " + GetMaleSurname();
        }

        public static string GetFemaleFullName()
        {
            return GetFemaleFirstName() + " " + GetFemaleSurname();
        }
    }
}
