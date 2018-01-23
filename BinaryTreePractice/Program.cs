using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePractice
{
    public class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;
    }

    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            Console.WriteLine("this is the input " + newNode.Data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if ( data < current.Data)
                    {
                        current = current.LeftChild;
                        //Console.WriteLine("this is current " + current.Data);
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            Console.WriteLine("this is parent.LeftChild " + parent.LeftChild.Data);
                            // if we create a left child we can break out of the loop
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            Console.WriteLine("this is parent.RightChild " + parent.RightChild.Data);
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
            Console.WriteLine("This is where your number is in the tree: ");
            tree1.add(myNumber);



            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine( "Program written by : " + names );
            Console.WriteLine("******************************");
        }
    }

    
}
