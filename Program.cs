using System;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static char[] chararray;
        /// <summary>
        /// Week of 24 challenge- Hello LadyBug
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            int Q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < Q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string b = Console.ReadLine();
                bool result = SatisfyLady(n, b);
                foreach (char c in chararray)
                {
                    Console.Write(c);
                }                
            }         
        }
        /// <summary>
        /// Checks for the movement is possible or not
        /// </summary>
        /// <param name="length"></param>
        /// <param name="word"></param>
        /// <returns>oolean value</returns>
        static bool SatisfyLady(int length, string word)
        {
            chararray = word.ToCharArray();
            int count = 0;
            for(int i=0;i< chararray.Length-1; i++)
            {
                if (chararray[i].Equals('_'))
                {
                    count += 1;
                    swapunderscores(ref chararray[i], ref chararray[i+1], i);
                }
                if (word.Count(x => x == chararray[i]) <= 1)
                {
                    Console.WriteLine("Not a Happy Bug");
                }
                
            }
            if (count == 0)
            {
                int counterLength = 0;
                for(int k=0;k< chararray.Length-1; k++)
                {
                    if (chararray[k].Equals(chararray[k + 1]))
                    {
                        counterLength += 1;                             
                    }
                    else if (counterLength > 0)
                    {
                        Console.WriteLine(chararray[k] + " is a happy bug, I will check others");
                        counterLength = 0;
                    }
                    else { 
                        Console.WriteLine("No Happy Bug");
                        return false;
                    }

                }
               
            }

            
            return true;
        }

        /// <summary>
        /// Swaps underscores with the next item and swaps that item with the matching item.
        /// </summary>
        /// <param name="itemIndex"></param>
        /// <param name="nextItemIndex"></param>
        /// <param name="indexOfUnderScore"></param>
        static void swapunderscores(ref char itemIndex, ref char nextItemIndex, int indexOfUnderScore)
        {
            char temp= itemIndex;
            itemIndex=nextItemIndex;
            nextItemIndex =temp;
            swapletters(ref itemIndex, indexOfUnderScore);
        }
        /// <summary>
        /// Swaps the color item on the board to the matching color item if it exists.
        /// </summary>
        /// <param name="itemIndex"></param>
        /// <param name="index"></param>
        private static void swapletters(ref char itemIndex, int index)
        {
            for(int j = 0; j < index; j++)
            {
                if (chararray[j].Equals(itemIndex))
                {
                    char temp = chararray[j+1];
                    chararray[j + 1]= itemIndex;
                    chararray[index] = temp;    
                            
                }
            }
        }
        
    }
}
