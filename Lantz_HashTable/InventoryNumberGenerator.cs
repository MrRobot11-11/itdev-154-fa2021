using System;
using System.Collections.Generic;
using System.Text;


namespace Lantz_HashTable
{
    class InventoryNumberGenerator
    {
        Random rnd = new Random();

        //Creates random number to be used as inventory number
        public int NewInventoryNum()
        {
            int newProduct = rnd.Next(100, 999);

            return newProduct;
        }




    }
}
