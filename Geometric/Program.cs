using System;


namespace Geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 10, 2, 3);
            Console.WriteLine("==Прямоугольник==");
            Console.WriteLine($"Площадь прямоугольника: {r.Area}");
            Console.WriteLine($"Периметр прямоугольника: {r.Perimeter}");
            Console.WriteLine($"Координата точки X: {r.X}");
            Console.WriteLine($"Координата точки Y: {r.Y}\n");

            Console.WriteLine("==Изменение значений==");
            r.Width = 16;
            r.Height = 20;
            r.X = -5;
            r.Y = 0;


            Console.WriteLine("==Прямоугольник==");
            Console.WriteLine($"Площадь прямоугольника: {r.Area}");
            Console.WriteLine($"Периметр прямоугольника: {r.Perimeter}");
            Console.WriteLine($"Координата точки X: {r.X}");
            Console.WriteLine($"Координата точки Y: {r.Y} \n");


            Console.WriteLine("==Использование нескольких прямоугольников==");
            var rectangles = new[]
            {
                new Rectangle(0,5,2,3),
                new Rectangle(1,15,9,5),
                new Rectangle(7, 6, -5,10)
            };

            foreach (var rect in rectangles)
            {
                Console.WriteLine(rect.ToString());
            }
        }
    }
}
