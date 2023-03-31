using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Die
    {
        private int _roll;
        private Random _generator;
        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }
        public Die(int roll)
        {
            _generator = new Random();
            _roll = roll;

        }

        public int Roll { get { return _roll; } }

        public override string ToString()
        {
            return _roll.ToString();
        }
        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public void DrawRoll()
        {
            if(_roll == 1)
            {
                Console.WriteLine("____________");
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine("|    ()    |");
                Console.WriteLine("|          |");
                Console.WriteLine("|__________|");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("____________");
                Console.WriteLine("| ()       |");
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine("|       () |");
                Console.WriteLine("|__________|");
            }
        }

    }
    

}
