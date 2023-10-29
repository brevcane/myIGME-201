using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q9
{
    internal class Program
    {
        public abstract class Player
        {
            private string name;
            private int age;
            private bool hasBall;

            virtual public void SignatureMove()
            {
                // This is the default signature move for players who aren't special enough to have their own
                Console.WriteLine("Juggle ball.");
            }

            public abstract void Pass(Player player);

            public string Name() { return name; }
        }

        public interface IScore
        {
            void Shoot();
        }

        public interface IDefend
        {
            void Tackle();
        }

        public class Forward : Player, IDefend, IScore
        {
            public override void Pass(Player player)
            {
                Console.WriteLine("Passes the ball to the defined player.");
            }

            public override void SignatureMove()
            {
                Console.WriteLine("Performs a rainbow with the ball.");
            }

            public void Shoot()
            {
                Console.WriteLine("Shoots ball.");
            }

            public void Tackle()
            {
                Console.WriteLine("Attempts to tacle and steal the ball.");
            }

            public void Dribble()
            {
                Console.WriteLine("Tries to dribble through a crowd of defenders.");
            }
        }

        public class Midfield : Player, IDefend, IScore
        {
            public override void Pass(Player player)
            {
                Console.WriteLine("Passes the ball to the defined player.");
            }

            public override void SignatureMove()
            {
                Console.WriteLine("Performs a perfect cross.");
            }

            public void Shoot()
            {
                Console.WriteLine("Shoots ball.");
            }

            public void Tackle()
            {
                Console.WriteLine("Attempts to tacle and steal the ball.");
            }

            public void Cross()
            {
                Console.WriteLine("Tries to cross the ball in front of the other team's box.");
                
            }
        }

        public class Goalie : Player, IDefend
        {
            public override void Pass(Player player)
            {
                Console.WriteLine("Passes the ball to the defined player.");
            }

            public void Tackle()
            {
                Console.WriteLine("Attempts to tacle and steal the ball.");
            }

            public void Save()
            {
                Console.WriteLine("Tries to save an incoming shot.");
            }
        }

        static void Main(string[] args)
        {
            Goalie goalie = new Goalie();
            Forward forward = new Forward();
            Midfield midfield = new Midfield();

            MyMethod(goalie);
            MyMethod(forward);
            MyMethod(midfield);
        }

        static void MyMethod(object obj)
        {
            Console.WriteLine("Calling MyMethod with object of type: " + obj.GetType().Name);

            if (obj is Player player)
            {
                player.Pass(player);
                player.SignatureMove();

                if (obj is IScore scorer)
                {
                    scorer.Shoot();
                }

                if (obj is IDefend defender)
                {
                    defender.Tackle();
                }
   
            }
            else
            {
                Console.WriteLine("Object is not a Player");
            }

            Console.WriteLine();
        }
    }
}
