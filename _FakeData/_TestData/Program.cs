using _FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NetworkData.GetMaleMailAddress("box.az"));
            Console.ReadLine();
        }
    }
}
