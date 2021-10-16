using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement
{
    class Advertisement
    {
        public string Name { get; set; }


        public int Price { get; set; }

        public string NameSeller { get; set; }


        public Advertisement(string name, int price, string nameSeller)
        {
            Name = name;
            Price = price;
            NameSeller = nameSeller;

        }

        public override string ToString()
        {
            return $"{Name} {Price} {NameSeller} ";

        }

        public int CompareTo(object obj)
        {
            Advertisement advertisementToCompare = (Advertisement)obj;
            if (Price > advertisementToCompare.Price)
            {
                return 1;
            }
            else if (Price == advertisementToCompare.Price)
            {
                return 0;
            }
            else
            {
                return -1;
            }


        }
        public static bool operator >(Advertisement a1, Advertisement a2)
        {
            return a1.Price > a2.Price;
        }

        public static bool operator <(Advertisement a1, Advertisement a2)
        {
            return a1.Price < a2.Price;
        }

    }
}
