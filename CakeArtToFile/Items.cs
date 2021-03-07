using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeArtToFile
{
    class Items
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }

        public Items(string name, string price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public override string ToString()
        {
            return " Name : " + this.Name + ", Price : " + this.Price + ", Type : " + this.Type;
        }



    }
}
