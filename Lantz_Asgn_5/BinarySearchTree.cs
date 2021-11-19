using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using static System.Console;

namespace Lantz_Asgn_5
{
    public class BinarySearchTree
    {
        //Made this global so I could access it from the controller
        //The value of the root changes throughout operation
        //Value is needed for various functions
        public Node root = null;
        public View vw = new View();
        
        //Ask user to create a tree with (n) number of nodes
        public void CreateTree()
        {
            int i, n, data;
            
            WriteLine("\nEnter the number of nodes you would like to create: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                root = Insert(root, data);
            }
            WriteLine("");
            WriteLine("\nThis is the tree we created!");
            vw.CurrentValue();
            InOrder(root);

        }

        public Node NewNode(int item)
        {
            Node temp = new Node();
            temp.key = item;
            temp.left = temp.right = null;
            return temp;
        }
       
      
        //Recursive function to do in order traversal of BST
        public void InOrder(Node root)
        {
                if(root != null) 
                {
                    InOrder(root.left);
                    Write(root.key + " ");
                    InOrder(root.right);
                }
        }
        
        //Function to insert a new node w/ given key in BST
        public Node Insert(Node node, int key)
        {
            //If the tree is empty, return a new node
            if (node == null) 
                return NewNode(key);

            //If tree is not empty
            if (key < node.key)
                node.left = Insert(node.left, key);
            else
                node.right = Insert(node.right, key);

            //Return the (unchanged) node pointer
            return node;
        }

        // Given a binary search tree and a key, this
        // function deletes the key and returns the
        // new root
        public Node DeleteNode(Node root, int k)
        {
            // Base case
            if (root == null)
            {
                Write("Tree is empty: ");
                return root;
            }
           

            // Recursive calls for ancestors of
            // node to be deleted
            if (root.key > k)
            {
                root.left = DeleteNode(root.left, k);
                return root;
            }
            else if (root.key < k)
            {
                root.right = DeleteNode(root.right, k);
                return root;
            }

            // We reach here when root is the node
            // to be deleted.

            // If one of the children is empty
            if (root.left == null)
            {
                Node temp = root.right;
                return temp;
            }
            else if (root.right == null)
            {
                Node temp = root.left;
                return temp;
            }

            // If both children exist
            else
            {
                Node succParent = root;

                // Find successor
                Node succ = root.right;

                while (succ.left != null)
                {
                    succParent = succ;
                    succ = succ.left;
                }

                // Delete successor. Since successor
                // is always left child of its parent
                // we can safely make successor's right
                // right child as left of its parent.
                // If there is no succ, then assign
                // succ->right to succParent->right
                if (succParent != root)
                    succParent.left = succ.right;
                else
                    succParent.right = succ.right;

                // Copy Successor Data to root
                root.key = succ.key;

                return root;
            }
        }




    }//End of class
}//End of namespace
