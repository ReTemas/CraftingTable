using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CraftingTable
{
    public class Inventory
    {

        public Item[] item = new Item[2];

        public Inventory()
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (i == 0)
                {
                    item[i] = new Item("Доска");
                }
                if (i == 1)
                {
                    item[i] = new Item("Булыжник");
                }
            }
        }

        public void ShowAllInventory()
        {
            StringBuilder my = new StringBuilder();
            for (int i = 0; i < item.Length; i++)
            {
                my.AppendFormat($"{item[i].name}: {item[i].count}\n");
            }

            string inventory = my.ToString();
            WriteLine(inventory);

            ReadLine();
        }

        public static CompletedItem operator +(Inventory firstItem, Inventory secondItem)
        {
            return new CompletedItem
            {
                NameOfItem = Table.WhatIsThis(),
                Parts = new Inventory[] { firstItem, secondItem }
            };
        }
    }
}
