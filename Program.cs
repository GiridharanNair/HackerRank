using System;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
           
            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());               
                //Adjust to the number of rotations based on the swap count k
                //From that position move to the relative query position that was required
                //Note Items are based on zero index
                Console.WriteLine(a[(n - k + m) % n]);
                
            }
        }

        
    }
}
