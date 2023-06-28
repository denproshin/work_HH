using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace СalculationSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип фигуры:") ;
            Console.WriteLine("1. Круг.");
            Console.WriteLine("2. Треугольник.");
            Console.WriteLine("");

            int selectedItem = Convert.ToInt32(Console.ReadLine());
            
            switch (selectedItem)
            {
                case 1:
                    {
                        Console.Clear();
                        double squareCircle;
                        Console.Write("Введите радиус круга: ");
                        double radiusCircle = Convert.ToDouble(Console.ReadLine());

                        squareCircle = Math.PI * Math.Pow(radiusCircle, 2);

                        Console.Write("Площадь круга = ");
                        Console.Write(squareCircle);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        double squareTriangle;
                        Console.Write("Введите первый катет треугольника: ");
                        double firstСathet = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второй катет треугольника: ");
                        double secondСathet = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите биссектрису треугольника: ");
                        double bisector = Convert.ToDouble(Console.ReadLine());
                        if (firstСathet + secondСathet > bisector || bisector + secondСathet > firstСathet ||
                            bisector + firstСathet > secondСathet)
                        {
                            double halhMeter = (firstСathet + secondСathet + bisector) / 2;

                            squareTriangle = Math.Sqrt(halhMeter * (halhMeter - firstСathet) *
                                                                 (halhMeter - secondСathet) *
                                                                 (halhMeter - bisector));
                            Console.WriteLine("");
                            Console.Write("Площадь треугольника = ");
                            Console.Write(squareTriangle);
                        }
                        else
                        {
                            Console.WriteLine("Треугольника с данными сторонами не существует.");
                        }
                        Console.WriteLine("");
                        if (Math.Pow(bisector, 2) == Math.Pow(firstСathet, 2) + Math.Pow(secondСathet, 2))
                        {
                            Console.WriteLine("Данный треугольник является прямоугольным.");
                        }
                        else { Console.WriteLine(""); }
                        
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Введите пункт содержащийся в меню.");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
