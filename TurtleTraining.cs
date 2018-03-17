using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;



namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            int i = 0;
            int Stepsize = 20;
            while (i < 10)
            {
                if (i%2 == 0)
                {
                    Turtle.Move(Stepsize);
                    Turtle.TurnRight();
                    Turtle.Move(Stepsize);
                    Turtle.TurnRight();
                } else
                {
                    Turtle.Move(Stepsize);
                    Turtle.TurnLeft();
                    Turtle.Move(Stepsize);
                    Turtle.TurnLeft();
                }
                
                i++;
            }

        }
    }
}
