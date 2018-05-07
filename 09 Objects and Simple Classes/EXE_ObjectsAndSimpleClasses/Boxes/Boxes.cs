using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double ReturnDistance(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }
    }

    class Box
    {
        public Point UpperRight { get; set; }
        public Point BottomRight { get; set; }
        public Point UpperLeft { get; set; }
        public Point BottomLeft { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

    class Boxes
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                int[] tokens = input.Split(new string[] { " | ", ":" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                boxes.Add(new Box()
                {
                    UpperLeft = new Point()
                    {
                        X = tokens[0],
                        Y = tokens[1]
                    },
                    UpperRight = new Point()
                    {
                        X = tokens[2],
                        Y = tokens[3]
                   },
                    BottomLeft = new Point()
                    {
                        X = tokens[4],
                        Y = tokens[5]
                    },
                    BottomRight = new Point()
                    {
                        X = tokens[4],
                        Y = tokens[5]
                    }
                });

                input = Console.ReadLine();
            }

            for (int i = 0; i < boxes.Count; i++)
            {
                Box currentBox = boxes[i];

                currentBox.Width = (int)currentBox.UpperLeft.ReturnDistance(currentBox.UpperRight);
                currentBox.Height = (int)currentBox.UpperLeft.ReturnDistance(currentBox.BottomLeft);

                Console.WriteLine($"Box: {currentBox.Width}, {currentBox.Height}");
                Console.WriteLine($"Perimeter: {currentBox.CalculatePerimeter()}");
                Console.WriteLine($"Area: {currentBox.CalculateArea()}");
            }

        }
    }
}
