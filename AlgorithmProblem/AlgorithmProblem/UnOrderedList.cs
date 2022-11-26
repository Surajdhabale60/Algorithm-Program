using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class UnOrderedList
    {
        public void ReadALlTextFiles(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(",");
            LinkedListGeneric<string> linkedList = new LinkedListGeneric<string>();
            foreach (var data in words)
            {
                linkedList.AddLast(data);
            }
            Console.Write("Enter word to search : ");
            string check = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.Equals(check))
                {
                    linkedList.SearchDelete(data);
                    linkedList.Display();
                    return;
                }
            }
            linkedList.AddLast(check);
            linkedList.Display();
        }
    }
}
