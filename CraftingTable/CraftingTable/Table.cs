using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CraftingTable
{
    public class Table
    {
        public static void Crafting(Inventory myInventory)
        {
            Slot[] Slot = new Slot[9];
            for(int i = 0; i < Slot.Length; i++)
            {
                Slot[i] = new Slot(i);
            }
            
            int numberOfAction = 1;
            int numberOfSlot;
            string NameOfItem;

            while (numberOfAction!=0)
            {
                WriteLine("0) Выход\n1) Положить\n2) Взять\n3) Скрафтить");

                WriteLine("----------------");
                WriteLine($"|{Slot[0].NameOfItem}|{Slot[1].NameOfItem}|{Slot[2].NameOfItem}|");
                WriteLine("----------------");
                WriteLine($"|{Slot[3].NameOfItem}|{Slot[4].NameOfItem}|{Slot[5].NameOfItem}|");
                WriteLine("----------------");
                WriteLine($"|{Slot[6].NameOfItem}|{Slot[7].NameOfItem}|{Slot[8].NameOfItem}|");
                WriteLine("----------------");

                numberOfAction = Convert.ToInt32(ReadLine());
                if (numberOfAction == 1)
                {
                    WriteLine("Какой предмет положить?");
                    NameOfItem = ReadLine();

                    WriteLine("Номер слота: ");
                    numberOfSlot = Convert.ToInt32(ReadLine());

                    for (int i = 0; i < myInventory.item.Length; i++)
                    {
                        if (NameOfItem == myInventory.item[i].name)
                        {
                            Slot[numberOfSlot].NameOfItem = myInventory.item[i].name;
                            break;
                        }
                    }
                }
            }
        }

        public static string WhatIsThis()
        {
            return "1";
        }
    }
}
