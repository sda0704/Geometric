using System;


namespace Geometric
{
    internal class Rectangle
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }


        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }



        private double _width;
        private double _height;


        public Rectangle(double width, double height, double x, double y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
        public double Height
        {
            get => _height;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Ошибка! Высота не может быть отрицательной");
                }
                _height = value;
            }
        }
        public double Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ошибка! Ширина не может быть отрицательной");     
                }
                _width = value;
            }
        }
        public double Area => Height * Width;
        public double Perimeter => (Height + Width) * 2;

        public override string ToString()
        {
            return
                $"Площадь: {Area} " +
                $"Периметр: {Perimeter} " +
                $"Координата точки X: {X} " +
                $"Координата точки Y: {Y} " ;
            
        }
    }


}