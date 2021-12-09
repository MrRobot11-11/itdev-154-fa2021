using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;
 



namespace Lantz_HashTable
{
    //Class to hold all data structures
    public class Data
    {
        Hashtable groceryInventory = new Hashtable();
        InventoryNumberGenerator newNumber = new InventoryNumberGenerator();
        
        //Add items to the inventory.  Key is auto-generated
        public void AddToInventory()
        {
            bool stop = true;
            int inventoryNumber;
            string secondChoice, groceryItem;
            
            do
            {
                WriteLine("\nWhat item would you like to add?");
                groceryItem = ReadLine();
                inventoryNumber = newNumber.NewInventoryNum();
                groceryInventory.Add(inventoryNumber, groceryItem);
                WriteLine("\nYou added [{0}] to the system with inventory number [{1}]", groceryItem, inventoryNumber);

                WriteLine("\nWould you like to add another item?");
                WriteLine("Enter [Y] to add, enter [N] to exit");
                
                secondChoice = ReadLine().ToUpper();
                
                if (secondChoice == "Y")
                    stop = true;
                else
                    stop = false;

            } while (stop);
            DisplayTable();
        }

        //Search by key 
        public void SearchByKey(int itemKey) 
        {
            if (groceryInventory.Contains(itemKey))
            {
                WriteLine("\nThe item you are looking for is [{0}]", groceryInventory[itemKey].ToString());
            }
            else
            {
                WriteLine("The item you are looking for doesn't exist");
            }
        }

        //Search by value
        public void SearchByValue(string itemValue)
        {
            foreach(DictionaryEntry de in groceryInventory)
            {
                for (int i = 0; i < groceryInventory.Count; i++)
                {
                    if(Convert.ToString(de.Value) == itemValue)
                    {
                        WriteLine("\nThe item you are searching for " +
                            "has a key of [{0}]", de.Key);
                        break;
                    }
                    else 
                    {
                        WriteLine("Item was not found in inventory.");
                    }
                }
            }
        }
        
        //Delete an item from inventory
        public void DeleteFromInventory(int itemNumber)
        {
            groceryInventory.Remove(itemNumber);
        }
        
        public void DisplayTable()
        {
            WriteLine("\nAll items in inventory:  \n");
            
            foreach(DictionaryEntry de in groceryInventory)
            {
                WriteLine("Key: [{0}] Value: [{1}]", de.Key, de.Value);
            }
        }




    }
}
