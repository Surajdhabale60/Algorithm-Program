using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class BalancedParanthesis
    {
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            LinkListStack<string> stack = new LinkListStack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                {
                    stack.Push(data);
                }
                if (data.Equals(")"))
                {
                    stack.Pop();
                }
            }
            if (stack.Peek())
            {
                Console.WriteLine("Balanced Parantheses");
            }
            else
            {
                Console.WriteLine("Is Not Balanced Parantheses");
            }
            
        }
    }
}
