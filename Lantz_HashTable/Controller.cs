using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace Lantz_HashTable
{
    class Controller
    {
        public void RunProgram()
        {
            View vw = new View();
            Data hashData = new Data();

            int choice;
            
            while (true)
            {
                choice = vw.GetMenuChoice();

                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:  //Add an item to the system
                        hashData.AddToInventory();
                            break;

                    case 2: //Delete an item from the system by Id
                        WriteLine("What id number would you like to delete?");
                        var data = Convert.ToInt32(ReadLine());
                        hashData.DeleteFromInventory(data);
                        hashData.DisplayTable();
                        break;

                    case 3: //Search for item by id number
                        WriteLine("\nWhat is the id number you are looking for?");
                        var itemKey = Convert.ToInt32(ReadLine());
                        hashData.SearchByKey(itemKey);
                        break;

                    case 4://Search by item to get key
                        WriteLine("\nWhat item would you like to search for?");
                        var itemValue = ReadLine();
                        hashData.SearchByValue(itemValue);
                        break;

                    case 5: //Display all items in inventory
                        hashData.DisplayTable();
                        break;

                    case 6: //Exit the system
                        break;

                    default:
                        break;





                }








            }




        }








    }
}
