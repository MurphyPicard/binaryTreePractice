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
            if (root = null)
            {
                root = newNode;
            }
            else
            {
                // pause for now
            }
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            // initial commit
        }
    }

    
}
