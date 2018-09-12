using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CraftingTable
{
    class Program
    {
        static void Main(string[] args) {
            Inventory myInventory = new Inventory();

            int numberOfAction = 1;
            while (numberOfAction != 0)
            {
                Clear();
                WriteLine("0) Выход\n1) Инструкция\n2) Рецепты\n3) Верстак\n4) Мой инвентарь");
                numberOfAction = Convert.ToInt32(ReadLine());
                switch (numberOfAction) {
                    case 0: {
                            break;
                        }
                    case 1: {
                            break;
                        }
                    case 2: {
                            Recipes.ShowRecipes();
                            break;
                        }
                    case 3: {
                            Table.Crafting(myInventory);
                            break;
                        }
                    case 4: {
                            myInventory.ShowAllInventory();
                            break;
                        }
                }
            }
            
        }
    }
}
