using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleFeedGame
{
    class Program
    {

        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
           // Turtle.Speed = 9;
            GraphicsWindow.Height = 800;
            GraphicsWindow.Width = 600;
            GraphicsWindow.BrushColor = "White";
            var playzone = Shapes.AddRectangle(800, 600);
            GraphicsWindow.BrushColor = "Purple";
            var food = Shapes.AddRectangle(20, 20);

            Random r = new Random();
            int foodX = r.Next(0, 800);
            int foodY = r.Next(0, 600);
            //int foodX = 100;
            //int foodY = 200;
            Shapes.Move(food, foodX, foodY);
            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X.GreaterThan(foodX) && Turtle.X.LessThan(foodX+20) && Turtle.Y.GreaterThan(foodY) && Turtle.Y.LessThan(foodY+20))
                {
                    foodX = foodX + 25; // перемещение еды согласно заданию
                    //foodX = r.Next(0, 780); // случайное появление еды
                    //foodY = r.Next(0, 580);
                    Shapes.Move(food, foodX, foodY);

                }
                if (Turtle.X.GreaterThan(800))
                {
                    Turtle.X = 0;
                }
                if (Turtle.X.LessThan(0))
                {
                    Turtle.X = 800;
                }
                if (Turtle.Y.GreaterThan(600))
                {
                    Turtle.Y = 0;
                }
                if (Turtle.Y.LessThan(0))
                {
                    Turtle.Y = 600;
                }
            }

        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
