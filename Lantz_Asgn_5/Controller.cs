using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using static System.Console;

namespace Lantz_Asgn_5
{
    public class Controller
    {
        BinarySearchTree bst = new BinarySearchTree();//BST object
        View vw = new View(); //View object

        //Function that will run the whole program
        public void Run()
        {
            int choice, data; 

            vw.HelloUser();//Explains program to user

            bst.CreateTree();//User creates a tree of a size of their choosing
            
            while (true)
            {
                choice = vw.GetMenuChoice();

                if (choice == 4)
                    break;

                switch (choice)
                {
                    case 1: //Display the contents of tree
                        bst.InOrder(bst.root);
                        break;

                    case 2: //Add a value to the tree
                        WriteLine("What value would you like to add to the tree?");
                        data = Convert.ToInt32(Console.ReadLine());
                        bst.Insert(bst.root, data);
                        bst.InOrder(bst.root);
                        break;
                }





                
            }
            
            
            
        }
      
       
    



    }

    

}

