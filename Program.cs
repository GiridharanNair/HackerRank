using System;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            string adjString;
            char[] adjCharArray;
            adjString = Console.ReadLine();
            ReadData(adjString, out adjCharArray);
            if (adjCharArray.Length <= 0)
                Console.WriteLine("Empty String");
            else
            {   
                Console.WriteLine(adjCharArray);
            }            
        }

        /// <summary>
        /// Read Data and delete the adjascent records
        /// </summary>
        /// <param name="adjString"></param>
        /// <param name="adjCharArray"></param>
        /// <returns></returns>
        private static string ReadData(string adjString, out char[] adjCharArray)
        {
            adjCharArray = adjString.ToCharArray();
            for (int i = 0; i < adjCharArray.Length - 1; i++)
            {
                if (adjCharArray[i].Equals(adjCharArray[i + 1]))
                    Delete(i, ref adjCharArray);
            }

            foreach (char c in adjCharArray)
            {
                if (!c.Equals(default(char)))
                    adjString += c;
            }
            return adjString;
        }
        /// <summary>
        /// Delete an existing adjascent match and redo to see if the next instances also matches
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="adjCharArray"></param>
        private static void Delete(int v1, ref char[] adjCharArray)
        {
            string data = String.Empty;
            //Console.WriteLine(adjCharArray[v1]+ " "+adjCharArray[v1+1]);
            adjCharArray[v1] = default(char);
            adjCharArray[v1+1]= default(char);
            
            foreach (char c in adjCharArray)
            {
                if (!c.Equals(default(char)))
                    data += c;
            }

            ReadData(data, out adjCharArray);
        }

        
    }
}
