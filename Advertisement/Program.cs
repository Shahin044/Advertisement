using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement a1 = new Advertisement("game", 500, "Əli");
            Advertisement a2 = new Advertisement("computer", 200, "Vaqif");
            Advertisement a3 = new Advertisement("mobile", 400, "Seymur");

            Advertisement[] price = { a1, a2, a3 };

            try
            {
                Array.Sort(price);
            }
            catch (Exception)
            {

                Console.WriteLine("Gonderdiyin arry sort oluna bilmir");
            }

            foreach (Advertisement item in price)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(a1 > a2);


        }
    }
    enum Category : byte
    {
        Radio, Mobile, Social
    }
    }
