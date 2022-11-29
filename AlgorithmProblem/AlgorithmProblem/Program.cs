using System;

namespace AlgorithmProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {               
                Console.WriteLine("select option\n 1.Binary Search\n 2.Insertion Sort\n 3.Bubble Sort\n 4.Anagram\n 5.UserInput\n 6.LinkedListGeneric\n 7.Prime Range\n 8.Palindrome And Anagram\n 9.UnOrdered List\n 10.Balanced Parantheses\n 11.Ordered List\n 12.Bank Cash Counter\n 13.Merge Sort\n 14.Palindrome Check");
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
                    case 6:
                        LinkedListGeneric<string> linkedListGeneric = new LinkedListGeneric<string>();
                        linkedListGeneric.AddLast("Suraj");
                        linkedListGeneric.Display();
                        break;
                    case 7:
                        PrimeRange primeRange = new PrimeRange();
                        primeRange.Prime();
                        break;
                    case 8:
                        PalindromeAndAnagram palindromeAndAnagram = new PalindromeAndAnagram();
                        palindromeAndAnagram.PrimeNumber();
                        palindromeAndAnagram.Palindrome();
                        palindromeAndAnagram.AnagramCheck();                        
                        break;
                    case 9:
                        UnOrderedList unOrderedList = new UnOrderedList();
                        unOrderedList.ReadALlTextFiles (@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProblem\AlgorithmProblem\BinarySearch.txt");
                        break;
                    case 10:
                        BalancedParanthesis balancedParanthesis = new BalancedParanthesis();
                        balancedParanthesis.ReadTextFile(@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProblem\AlgorithmProblem\Number.txt");
                        break;
                    case 11:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadTextFile(@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProblem\AlgorithmProblem\Ordered.txt");
                        break;
                    case 12:
                        BankCounter bankCounter = new BankCounter();
                        bankCounter.Counter();
                        break;
                    case 13:
                        int[] array = { 8, 5, 4, 2, 7, 3, 6, 1 };
                        int[] array2 = { 12, 15, 14, 17, 19, 18 };
                        MergeSort Sort = new MergeSort();
                        Console.WriteLine("Array Before Sorting: ");
                        Sort.Display(array);
                        Sort.MergeSorts(array, 0, array.Length - 1);
                        Console.WriteLine("Array after Sorting: ");
                        Sort.Display(array);
                        break;
                    case 14:
                        Palindrome palindrome = new Palindrome();
                        palindrome.ReadAllTextFile(@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProblem\AlgorithmProblem\Palindrome.txt");
                        break;
                }
            }
        }
    }
}