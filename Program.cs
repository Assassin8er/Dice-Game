namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            Die dice1 = new Die();
            dice1.DrawRoll();
            Die dice2 = new Die();
            dice2.DrawRoll();
        }
    }
}