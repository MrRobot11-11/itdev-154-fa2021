using System;
using System.Collections.Generic;
using System.Text;

namespace Lantz_HashTable
{
    class Controller
    {
        public void RunProgram()
        {
            View vw = new View();
            InventoryNumberGenerator numGen = new InventoryNumberGenerator();

            int choice, data;
            string groceryItem;

            while (true)
            {
                choice = vw.GetMenuChoice();

                if (choice == 5)
                    break;

                switch (choice)
                {
                    case 1:  //Add an item to the system
                            break;

                    case 2: //Delete an item from the system
                        break;

                    case 3: //Search for item by id number
                        break;

                    case 4: //Display all items in inventory
                        break;

                    case 5: //Exit the system
                        break;







                }








            }




        }








    }
}
