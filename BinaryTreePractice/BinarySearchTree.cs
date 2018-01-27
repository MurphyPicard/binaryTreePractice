using System;

namespace BinaryTreePractice
{
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

    
}
