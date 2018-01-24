using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePractice
{
    public class Node
    {
        // each node is data with a leftchild and rightchild
        public int Data;
        public Node LeftChild;
        public Node RightChild;
    }

    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            //making this a new tree
            root = null;
        }
        public void add(int data)
        {
            // making a new node
            Node newNode = new Node();
            newNode.Data = data;
            Console.WriteLine("Dropping plinko chip number " + newNode.Data + "... ");

            if (root == null)
            {
                // make the first number the root
                root = newNode;
            }
            else
            {

                Node current = root;
                Node parent;
                while (true)
                {
                    // sets the current root to be the parent
                    parent = current;
                    if ( data < current.Data)
                    {
                        current = current.LeftChild;
                        
                        // if no leftchild, one will be created here
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            Console.WriteLine("It worked!!! (whew)");
                            Console.WriteLine(parent.LeftChild.Data + " is the LeftChild of " + parent.Data);
                            // if we create a left child we can break out of the loop
                            break;
                        }
                    }
                    else
                    {

                        current = current.RightChild;

                        // if no rightchild, one will be created here
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            Console.WriteLine("It worked!!! (whew)");
                            Console.WriteLine( parent.RightChild.Data + " is the RightChild of " + parent.Data);
                            // if we create a right child we can break out of the loop
                            break;
                        }
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tree1 = new BinarySearchTree();
            tree1.add(50);
            tree1.add(30);
            tree1.add(60);
            tree1.add(40);
            tree1.add(70);
            var names = "Beatriz and Ara";

            Console.WriteLine("Please pick a number: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked " + myNumber + "... ");
            Console.WriteLine("I hope this works... ");
            tree1.add(myNumber);



            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine( "Program written by : " + names );
            Console.WriteLine("******************************");
        }
    }

    
}
