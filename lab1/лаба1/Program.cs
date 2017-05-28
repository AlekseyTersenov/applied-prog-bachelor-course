using System;

namespace PointOnСrossing
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l1 = new Line();
            Line l2 = new Line();

            Console.WriteLine("Введите координаты для первой линии");
            while (true)
            {
                try
                {
                    l1.init();
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Вы неправильно ввели координату точки");
                }
            }
            
            Console.WriteLine("Введите координаты для второй линии");
            while(true)
            { 
                try
                {
                    l2.init();
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Вы неправильно ввели координату точки");
                }
            }

            Console.WriteLine("Точка пересечения ваших прямых:");
            
            Point result = Line.getCrossing(l1, l2);

            if (result != null)
            {
                Console.WriteLine(result);
            }
            
            Console.ReadKey();
        }
    }
}
