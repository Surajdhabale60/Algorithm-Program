﻿namespace AlgorithmProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {                
                Console.WriteLine("select option\n 1.Binary Search\n 2.Insertion Sort\n 3.Bubble Sort\n 4.Anagram\n 5.UserInput");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadTextFile(@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProblem\AlgorithmProblem\TextFile1.txt");
                        binarySearch.BinarySearchOperation("Something");
                        break;
                    case 2:
                        InsertionSort sort = new InsertionSort();
                        int[] binaryarr = { 5, 3, 1, 2, 4 };
                        sort.Sort(binaryarr);
                        break;
                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        int[] arr = { 8, 5, 7, 9, 6 };
                        bubbleSort.Sort(arr);
                        break;
                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram("heart", "earth");
                        break;
                    case 5:
                        UserInput userInput = new UserInput();
                        userInput.ReplaceString();
                        break;

                }
            }
        }
    }
}