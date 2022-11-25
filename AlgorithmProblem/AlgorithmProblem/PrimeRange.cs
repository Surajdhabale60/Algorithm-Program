using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class PrimeRange
    {
        public void Prime()
        {
            int i = 0;
            Console.WriteLine("Enter Last Range Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered Prime Number Range Are:");
            while (i < num)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Console.WriteLine(i + " ");
                }
                i++;
            }
        }
    }
}
