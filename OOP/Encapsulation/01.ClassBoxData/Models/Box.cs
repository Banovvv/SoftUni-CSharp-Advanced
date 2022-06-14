using System;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            private set
            {
                CheckValidity(nameof(this.Length), value);
                length = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                CheckValidity(nameof(this.Width), value);
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                CheckValidity(nameof(this.Height), value);
                height = value;
            }
        }

        //SurfaceArea=2lw+2lh+2wh
        public double SurfaceArea() => 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;

        //LateralSurfaceArea=2h(l + w)
        public double LateralSurfaceArea() => 2 * Height * (Length + Width);

        //Volume = lwh
        public double Volume() => Length * Width * Height;

        private void CheckValidity(string propertyName, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} cannot be zero or negative.");
            }
        }
    }
}
