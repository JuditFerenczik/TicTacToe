using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ticTac = new string[3, 3];
            int k = 1;
            for(int i = 0; i<= 2; i++)
            {
                for(int j= 0; j <= 2; j++)

                {
                        ticTac[i, j] =" | " + Convert.ToString(k);
                        Console.Write(ticTac[i, j]);
                    k++;
                    
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
            string[] validinputs = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "k" };

            Console.WriteLine("Add meg a következő számt!");
            string input = "k";





        }
    }
}
