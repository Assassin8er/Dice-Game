namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BetType = 0;
            double bet = 0, balance = 100.00, win = 0;
            bool done0  = false;
            bool done1 = false;
            Die dice1 = new Die();
            Die dice2 = new Die();
            Console.WriteLine("Welcome to Dice Game!");//Dice Game
            while (!done0)
            {
                done1 = false;
                Console.WriteLine("Please enter the # of the following Options");
                Console.WriteLine(" _______________________");
                Console.WriteLine("|1:Not Doubles          |");
                Console.WriteLine("|2:Doubles              |");
                Console.WriteLine("|3:EvenSum             |");
                Console.WriteLine("|4:OddSum              |");
                Console.WriteLine("|5:QUIT                 |");
                Console.WriteLine("|/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\\|");
                if (int.TryParse(Console.ReadLine(), out BetType)&&  BetType >= 1 && BetType <=5)
                {
                    if (BetType == 1)
                    {
                        while (!done1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Welcome to \"Not Doubles\". In this game you win by rolling non matching die.");
                            Console.WriteLine($"You Currently have ${Math.Round(balance, 2)}");
                            Console.WriteLine("Enter Your Bet:");
                            if (double.TryParse(Console.ReadLine(), out bet) && bet <= balance && bet >= 0)
                            {
                                Console.WriteLine("Rolling...");
                                Thread.Sleep(1000);
                                dice1.RollDie();
                                dice2.RollDie();
                                dice1.DrawRoll();
                                dice2.DrawRoll();
                                if (dice1.Roll != dice2.Roll)
                                {
                                    win = bet / 2;
                                    Console.WriteLine($"You won :{Math.Round(win, 2)}$");
                                    balance = balance + win;
                                    done1 = true;
                                }
                                else
                                {
                                    Console.WriteLine($"You Lost:${Math.Round(bet, 2)}");
                                    Console.WriteLine("Better Luck Next Time!");
                                    Console.WriteLine();
                                    balance = balance - bet;
                                    done1 = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! try again.");
                            }
                        }
                    }
                    else if (BetType == 2)
                    {
                        while (!done1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Welcome to \"Doubles\". In this game you win by rolling DOUBLES.");
                            Console.WriteLine($"You Currently have ${Math.Round(balance, 2)}");
                            Console.WriteLine("Enter Your Bet:");
                            if (double.TryParse(Console.ReadLine(), out bet) && bet <= balance && bet >= 0)
                            {
                                Console.WriteLine("Rolling...");
                                Thread.Sleep(1000);
                                dice1.RollDie();
                                dice2.RollDie();
                                dice1.DrawRoll();
                                dice2.DrawRoll();
                                if (dice1.Roll == dice2.Roll)
                                {
                                    win = bet * 2;
                                    Console.WriteLine($"You won :{Math.Round(win, 2)}$");
                                    balance = balance + win;
                                    done1 = true;
                                }
                                else
                                {
                                    Console.WriteLine($"You Lost:${Math.Round(bet, 2)}");
                                    Console.WriteLine("Better Luck Next Time!");
                                    Console.WriteLine();
                                    balance = balance - bet;
                                    done1 = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! try again.");
                            }
                        }
                    }
                    else if (BetType == 3)
                    {
                        while (!done1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Welcome to \"EvenSum\". In this game you win by rolling an even number.");
                            Console.WriteLine($"You Currently have ${Math.Round(balance, 2)}");
                            Console.WriteLine("Enter Your Bet:");
                            if (double.TryParse(Console.ReadLine(), out bet) && bet <= balance && bet >= 0)
                            {
                                Console.WriteLine("Rolling...");
                                Thread.Sleep(1000);
                                dice1.RollDie();
                                dice2.RollDie();
                                int Sum = dice1.Roll + dice2.Roll;
                                dice1.DrawRoll();
                                dice2.DrawRoll();
                                if (Sum%2 == 0)
                                {
                                    win = bet;
                                    Console.WriteLine($"You won :{Math.Round(win, 2)}$");
                                    balance = balance + win;
                                    done1 = true;
                                }
                                else
                                {
                                    Console.WriteLine($"You Lost:${Math.Round(bet, 2)}");
                                    Console.WriteLine("Better Luck Next Time!");
                                    Console.WriteLine();
                                    balance = balance - bet;
                                    done1 = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! try again.");
                            }
                        }
                    }
                    else if (BetType == 4)
                    {
                        while (!done1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Welcome to \"OddSum\". In this game you win by rolling an odd number.");
                            Console.WriteLine($"You Currently have ${Math.Round(balance, 2)}");
                            Console.WriteLine("Enter Your Bet:");
                            if (double.TryParse(Console.ReadLine(), out bet) && bet <= balance && bet >= 0)
                            {
                                Console.WriteLine("Rolling...");
                                Thread.Sleep(1000);
                                dice1.RollDie();
                                dice2.RollDie();
                                int Sum = dice1.Roll + dice2.Roll;
                                dice1.DrawRoll();
                                dice2.DrawRoll();
                                if (Sum%2 == 1)
                                {
                                    win = bet;
                                    Console.WriteLine($"You won :{Math.Round(win, 2)}$");
                                    balance = balance + win;
                                    done1 = true;
                                }
                                else
                                {
                                    Console.WriteLine($"You Lost:${Math.Round(bet, 2)}");
                                    Console.WriteLine("Better Luck Next Time!");
                                    Console.WriteLine();
                                    balance = balance - bet;
                                    done1 = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! try again.");
                            }
                        }
                    }
                    else if (BetType == 5)
                    {
                        Console.WriteLine("Have a good day!");
                        Thread.Sleep(200);
                        done0 = true;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("INVALID INPUT!");
                }
            }
        }
    }
}