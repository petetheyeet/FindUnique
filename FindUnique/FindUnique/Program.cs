using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace FindUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to start test cases");
            string input = Console.ReadLine();

            if (Convert.ToInt32(input) == 1)
            {
                int temp = -1;
                Stopwatch sw = new Stopwatch();
                int[] array1 = { 1, 2, 4, 2, 1, 4, 5 };
                Console.WriteLine("Using Array: " + string.Join(", ", array1));
                sw.Restart();
                temp = getUniqueElement(array1);
                sw.Stop();
                Console.WriteLine("Found Unique Var " + temp + " in " + sw.ElapsedMilliseconds);

            }

            Console.ReadLine();

        }
        static int getUniqueElement(int[] inputArray)
        {
            List<int> tempList = inputArray.ToList();
            Dictionary<int, int> tempDict = new Dictionary<int, int>();
            foreach(int i in tempList)
            {
                if(tempDict.ContainsKey(i))
                {
                    int value = tempDict[i];
                    value++;
                    tempDict[i] = value;
                }
                else
                {
                    tempDict.Add(i, 1);
                }
            }
            foreach (KeyValuePair<int, int> kvp in tempDict)
            {
                if(kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }
            return -1;
        }
    }
}
