﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePractice
{

    class Program
    {
        static void Main(string[] args)
        {
            var tree1 = new BinarySearchTree();
            tree1.add(50);
            tree1.add(49);
            tree1.add(48);
            tree1.add(47);
            tree1.add(46);
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
            //test commit from main PC
        }
    }

    
}
