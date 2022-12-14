using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class BankCounter
    {
        public void Counter()
        {
            Console.WriteLine("Enter Bank Account Number");
            int amount = Convert.ToInt32(Console.ReadLine());
            QueeueAndDequeueGeneric<string> queueAndDequeue = new QueeueAndDequeueGeneric<string>();
            Console.WriteLine("Enter of length of queue");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string name = Console.ReadLine();
                queueAndDequeue.Enqueue(name);
            }
            while (length > 0)
            {
                Console.WriteLine("choose an option" + "\n" + "1.Deposite" + "\n" + "2.withdraw");
                int option = Convert.ToInt32((Console.ReadLine()));
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Amount To Deposite");
                        int deposite = Convert.ToInt32(Console.ReadLine());
                        amount += deposite;
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount To Withdraw");
                        int withdraw = Convert.ToInt32((Console.ReadLine()));
                        if (withdraw > amount)
                        {
                            Console.WriteLine("Insufficient Funds");
                        }
                        else
                            amount -= withdraw;
                        break;
                    default:
                        Console.WriteLine("Please Choose correct option");
                        break;
                }
                queueAndDequeue.Dequeue();
                length--;
            }
        }
    }
}
