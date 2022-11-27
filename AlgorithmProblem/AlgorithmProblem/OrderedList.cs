﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmProblem.LinkedListSort;

namespace AlgorithmProblem
{
    public class OrderedList
    {
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(",");
            SortingList<int> linkedlist = new SortingList<int>();
            foreach (var word in words)
            {
                int result = Convert.ToInt32(word);
                linkedlist.AddNode(result);
            }
            Console.WriteLine("Before Sorting:");
            linkedlist.Display();
            linkedlist.SortOrdereredList();
            Console.WriteLine("After Sorting:");
            linkedlist.Display();
        }
    }
}
