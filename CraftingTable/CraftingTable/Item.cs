using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTable
{
    public class Item
    {
        public string name { get; set; }
        public int count { get; set; }

        public Item(string name)
        {
            this.name = name;
            count = 20;
        }
    }
}
