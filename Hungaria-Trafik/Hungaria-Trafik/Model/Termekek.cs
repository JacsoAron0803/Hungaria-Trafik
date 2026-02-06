using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungaria_Trafik.Model
{
    internal class Termekek
    {
        private int Id;
        private string Name;
        private string Category;
        private int Price;
        private int Stock;
        private int Age_limit;

        public Termekek(int id, string name, string category, int price, int stock, int age_limit)
        {
            Id1 = id;
            Name1 = name;
            Category1 = category;
            Price1 = price;
            Stock1 = stock;
            Age_limit1 = age_limit;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Category1 { get => Category; set => Category = value; }
        public int Price1 { get => Price; set => Price = value; }
        public int Stock1 { get => Stock; set => Stock = value; }
        public int Age_limit1 { get => Age_limit; set => Age_limit = value; }
    }

}

