using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmProgram;

namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Program");

            BinarySearch binarysearch = new BinarySearch();
            binarysearch.ReadTextFile(@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProgram\AlgorithmProgram\BinarySearch.txt");
            binarysearch.BinarySearchOperation("Something");
        }
    }
}