namespace AlgorithmProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {                
                Console.WriteLine("select option\n 1.Binary Search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadTextFile(@"C:\Users\suraj\source\repos\217 .Net\Algorithm-Program\AlgorithmProblem\AlgorithmProblem\TextFile1.txt");
                        binarySearch.BinarySearchOperation("Something");
                        break;
                }
            }
        }
    }
}