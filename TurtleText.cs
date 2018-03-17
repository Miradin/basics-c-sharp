using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleText
{
    class Program
    {
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size/2);
            Turtle.Angle = 90;
            Turtle.Move(size);
        }

        static void WriteO(int size)
        {
            Turtle.Angle = 0;
            int i = 0;
            while (i < 4)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
                
                i++;
            }
        }

        static void WriteR(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            
            
            for (int i=0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(size / 1.5);
            }
            
            

        }

        


        static void Main(string[] args)
        {

            int baseX = 200;
            int baseY = 200;
            int spacing = 60;
            Turtle.Speed = 9;

            void LetterPos(int pos)
            {
                Turtle.X = baseX + spacing * pos;
                Turtle.Y = baseY;
            }

            LetterPos(0);
            WriteT(60);
            LetterPos(1);
            WriteO(30);
            LetterPos(2);
            WriteR(30);
            LetterPos(3);
            WriteT(30);
        }
    }
}
