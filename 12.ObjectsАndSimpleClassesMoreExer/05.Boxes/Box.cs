using System;

namespace _05.Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public int Width
        {
            get
            {
                return Math.Abs(UpperLeft.X - UpperRight.X);
            }
        }

        public int Height
        {
            get
            {
                return Math.Abs(UpperLeft.Y - BottomLeft.Y);
            }
        }

        public int CalculatePerimeter(int width, int height)
        {
            return width * 2 + height * 2;
        }

        public int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
}
