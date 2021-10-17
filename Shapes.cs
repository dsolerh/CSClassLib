using System;

namespace CSClassLib
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public virtual double Area { get; }

        public Shape(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width) { }

        public override double Area => Width * Height;
    }

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }

    public class Circle : Shape
    {
        public Circle(double d) : base(d, d) { }
        
        public override double Area => Width * Height * Math.PI;
    }
}