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
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
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
            var name = "Ara";
            Console.WriteLine(name + " Please type a number:  ");
            Console.ReadLine();
            Console.WriteLine("******************************");
            Console.WriteLine( tree1 );
            Console.WriteLine("******************************");
        }
    }

    
}
