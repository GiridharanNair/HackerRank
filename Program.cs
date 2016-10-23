using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {

        private static int SubStringsRequired(Dictionary<char, int> items, int noofCharacters, string word)
        {
            int finalCount = 0;
            foreach (char keys in items.Keys)
            {
                int requiredCharacters = noofCharacters / 4;
                if (items[keys] > requiredCharacters)
                {
                    int count = items[keys] - requiredCharacters;
                    string longestRun = new string(word.Select((c, index) => word.Substring(index).TakeWhile(e => e == c))
                                    .OrderByDescending(e => e.Count())
                                    .First().ToArray());
                    int longCount = longestRun.Length;
                    if (longCount < count)
                    {
                        finalCount += count+ (count-longCount);
                    }
                    else
                    finalCount += count;
                }
            }
            return finalCount;
        }

        static void Main(String[] args)
        {
            int noofCharacters = Convert.ToInt32(Console.ReadLine());
            if(noofCharacters>=4 && noofCharacters%4==0 && noofCharacters<=2000)
            {
                string enteredWord = Console.ReadLine();
                Regex check = new Regex("^[actgACTG]+$");
                if (check.IsMatch(enteredWord))
                {
                    //int count=0;
                     Dictionary<char, int> items = new Dictionary<char,int>();
                    items.Add('A', 0);
                    items.Add('C', 0);
                    items.Add('G', 0);
                    items.Add('T', 0);
                    foreach (char c in enteredWord)
                    {
                       int count = items[c];
                       items[c] = ++count;
                    }
                    int noOfSubstrings = SubStringsRequired(items, noofCharacters,enteredWord);
                    Console.WriteLine(noOfSubstrings);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
                Console.WriteLine("Number of characters should be n/4 times and minimum of 4 characters");

            Console.ReadLine();

            
        }

        

       
    }
    
}
