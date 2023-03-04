using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using COMPE361;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("create mySetA and call default constructor");
            Set<int> mySetA = new Set<int>();
            Console.WriteLine("mySetA is clear : " + mySetA.IsClear);
            mySetA.Add(2);
            mySetA.Add(6);
            mySetA.Add(4);
            mySetA.Add(12);
            mySetA.Add(2); // checking add method
            mySetA.Add(16);
            mySetA.Add(44);
            Console.WriteLine("mySetA is clear, after add elements : " +
            mySetA.IsClear);
            Console.Write("Print mySetA : ");
            foreach (var item in mySetA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            List<int> myGathering = new List<int>();
            myGathering.Add(52);
            myGathering.Add(16);
            myGathering.Add(7);
            myGathering.Add(7); // checking set constructor
            myGathering.Add(19);
            myGathering.Add(21);
            Console.WriteLine(" call parametrized constructor and create mySetB");
            Set<int> mySetB = new Set<int>(myGathering);
            Console.WriteLine("mySetB is clear : " + mySetB.IsClear);
            Console.Write("Print mySetB : ");
            foreach (var item in mySetB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.Write("unionSet = mySetA U mySetB : ");
            Set<int> unionSet = mySetA + mySetB;
            foreach (var item in unionSet)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine("\n62 should be removed : " + unionSet.Remove(62));
            Console.WriteLine("2 should be removed : " + unionSet.Remove(2));
            Console.Write("After removing 2 \nunionSet : ");
            foreach (var item in unionSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            static bool FilterA(int e)
            {
                return (e % 2 == 0) ? true : false;
            }
            Console.Write(" use unionSet to create filterSetA and even numbers with it:");


            Set<int> filterSetA = unionSet.Filter(FilterA);
            foreach (var item in filterSetA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.Write(" use filterSetA to create sortedSetA : ");
            var mySortedSetA = new COMPE361.SortedSet<int>(filterSetA);
            foreach (var item in mySortedSetA)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nAFter add 13 : ");
            mySortedSetA.Add(15);
            foreach (var item in mySortedSetA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n12 should be added : " + mySortedSetA.Add(12));
            Console.WriteLine("3 should be removed : " + mySortedSetA.Remove(3));
            Console.Write("After remove 18 : ");
            mySortedSetA.Remove(18);
            foreach (var item in mySortedSetA)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nAfter remove 22 : ");
            mySortedSetA.Remove(22);
            foreach (var item in mySortedSetA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            static bool FilterB(int e)
            {
                return (e % 2 != 0) ? true : false;
            }
            Console.Write("use unionSet to create filterSetB and odd numbers with it: ");
            Set<int> filterSetB = unionSet.Filter(FilterB);
            foreach (var item in filterSetB)

            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.Write(" use filterSetB to create sortedSetB : ");
            var mySortedSetB = new COMPE361.SortedSet<int>(filterSetB);
            foreach (var item in mySortedSetB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.Write("sortedunionSet = mySortedSetA U mySortedSetB : ");
            var sortedunionSet = mySortedSetA + mySortedSetB;
            foreach (var item in sortedunionSet)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nAfter add 14 : ");
            sortedunionSet.Add(14);
            foreach (var item in sortedunionSet)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nAfter removing 4 : ");
            sortedunionSet.Remove(14);
            foreach (var item in sortedunionSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}