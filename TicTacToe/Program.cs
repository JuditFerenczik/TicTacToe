using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[,] ticTactToe = new string[3, 3];
        var validInputs = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int k = 1;
        bool folytat = true;
        int odd = 1;
        string XO = "";
        bool nyert = false;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                string tmp = Convert.ToString(k);
                ticTactToe[i, j] = tmp;
                k++;
            }

        }

        while (folytat)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("| " + ticTactToe[i, j] + " ");

                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }


            XO = odd % 2 == 0 ? "X" : "O";
            Console.WriteLine(XO + ", which spot do you choose to attack?");
            string bemenet = Console.ReadLine();
            if (validInputs.Contains(bemenet))
            {

                switch (bemenet)
                {
                    case "1":
                        ticTactToe[0, 0] = XO;
                        break;
                    case "2":
                        ticTactToe[0, 1] = XO;
                        break;
                    case "3":
                        ticTactToe[0, 2] = XO;
                        break;
                    case "4":
                        ticTactToe[1, 0] = XO;
                        break;
                    case "5":
                        ticTactToe[1, 1] = XO;
                        break;
                    case "6":
                        ticTactToe[1, 2] = XO;
                        break;
                    case "7":
                        ticTactToe[2, 0] = XO;
                        break;
                    case "8":
                        ticTactToe[2, 1] = XO;
                        break;
                    case "9":
                        ticTactToe[2, 2] = XO;
                        break;
                    default:
                        Console.WriteLine("Choose a valid input!!");
                        break;
                }
                odd++;
                validInputs.Remove(bemenet);
                if ((ticTactToe[0, 0] == "X" && ticTactToe[0, 1] == "X" && ticTactToe[0, 2] == "X") ||
                   (ticTactToe[1, 0] == "X" && ticTactToe[1, 1] == "X" && ticTactToe[1, 2] == "X") ||
                   (ticTactToe[2, 0] == "X" && ticTactToe[2, 1] == "X" && ticTactToe[2, 2] == "X") ||
                   (ticTactToe[0, 0] == "X" && ticTactToe[1, 1] == "X" && ticTactToe[2, 2] == "X") ||
                   (ticTactToe[0, 0] == "X" && ticTactToe[1, 0] == "X" && ticTactToe[2, 0] == "X") ||
                   (ticTactToe[0, 1] == "X" && ticTactToe[1, 1] == "X" && ticTactToe[2, 1] == "X") ||
                   (ticTactToe[0, 2] == "X" && ticTactToe[1, 2] == "X" && ticTactToe[2, 2] == "X") ||
                   (ticTactToe[2, 0] == "X" && ticTactToe[1, 1] == "X" && ticTactToe[0, 2] == "X"))
                {
                    Console.WriteLine("X won the game!");
                    nyert = true;

                }
                else if (
              (ticTactToe[0, 0] == "O" && ticTactToe[0, 1] == "O" && ticTactToe[0, 2] == "O") ||
               (ticTactToe[1, 0] == "O" && ticTactToe[1, 1] == "O" && ticTactToe[1, 2] == "O") ||
               (ticTactToe[2, 0] == "O" && ticTactToe[2, 1] == "O" && ticTactToe[2, 2] == "O") ||
               (ticTactToe[0, 0] == "O" && ticTactToe[1, 1] == "O" && ticTactToe[2, 2] == "O") ||
               (ticTactToe[0, 0] == "O" && ticTactToe[1, 0] == "O" && ticTactToe[2, 0] == "O") ||
               (ticTactToe[0, 1] == "O" && ticTactToe[1, 1] == "O" && ticTactToe[2, 1] == "O") ||
               (ticTactToe[0, 2] == "O" && ticTactToe[1, 2] == "O" && ticTactToe[2, 2] == "O") ||
               (ticTactToe[2, 0] == "O" && ticTactToe[1, 1] == "O" && ticTactToe[0, 2] == "O"))
                {

                    Console.WriteLine("O won the game!");
                    nyert = true;
                }
            }
            else
            {
                Console.WriteLine("heeeey, you!!You cant trick me!!!! Choose a valid input!");
            }
            if (nyert || validInputs.Count == 0)
            {
                if (validInputs.Count == 0)
                {
                    Console.WriteLine("Its a tie.");
                }
                Console.WriteLine("Would you like to conitue?(y/anything)?");
                string tmp2 = Console.ReadLine();
                if (tmp2 == "y")
                {
                    folytat = true;
                    k = 1;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            string tmp = Convert.ToString(k);
                            ticTactToe[i, j] = tmp;
                            k++;
                        }
                    }
                    for (int i = 1; i < 10; i++)
                    {
                        validInputs.Add(Convert.ToString(i));
                    }

                }
                else
                {
                    folytat = false;
                }
                // 
            }
            Console.ReadKey();
            Console.Clear();
        }


    }
}