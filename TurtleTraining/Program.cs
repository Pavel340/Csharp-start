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
            Turtle.Move(100);
            while (i < 2)
            {
                Turtle.Turn(45);
                Turtle.Move(100);
                Turtle.Turn(90);
                Turtle.Move(100);
                Turtle.Turn(45);
                Turtle.Move(100);
                i++;
            }
            
        }
    }
}
