using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungaria_Trafik.Model
{
    internal class Termekek
    {
        public Termekek(int id, string name, string category, int price, int stock, int age_limit)

        {

            this.id = id;

            this.name = name;

            this.category = category;

            this.price = price;

            this.stock = stock;

            this.age_limit = age_limit;

        }

        public int id { get; set; }

        public string name { get; set; }

        public string category { get; set; }

        public int price { get; set; }

        public int stock { get; set; }

        public int age_limit { get; set; }

    }

}

