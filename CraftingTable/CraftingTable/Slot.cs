using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTable
{
    public class Slot
    {
        public string NameOfItem { get; set; }
        public bool BeOrNotToBe { get; set; }

        public Slot(int number) {
            NameOfItem = Convert.ToString(number);
            BeOrNotToBe = false;
        }
    }
}
