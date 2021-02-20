using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program // Ахмадеева Виктория
    {

        static void Main(string[] args)
        {
            #region  Task 1.
            // Написать программу "Анкета". Вопросы: имя, фамилия, рост, вес.
            // В результате информация выводится в одну строку.
            // а) используя склеивание;
            Console.Title = "Анкета";
            String q;
            String e;
            int a;
            int b;

            Console.WriteLine("Введите свое имя ");
            q = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите свою фамилию ");
            e = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите свой рост ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите свой вес ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(q + " " + e + " " + a + " " + b);

            // б) используя форматированный вывод;
            Console.WriteLine("{0} {1} {2} {3}", q, e, a, b);

            // в) *используя вывод со знаком $.
            Console.WriteLine($"{q} {e} {a} {b}");

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Task 2. 
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h).
            // m — масса тела в килограммах, h — рост в метрах.

            Console.Title = "Расчет индекса массы тела";

            Console.WriteLine("Введите свой вес в килограммах ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите свой рост в метрах ");
            double h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);
            Console.WriteLine("Ваш индекс массы равен = " + I);

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Task 3.
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами х1,х2 и у1,у2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            Console.Title = "Подсчёт расстояние между точками с координатами х1,х2 и у1,у2";
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками х1,х2 и у1,у2 = " + r);
            Console.ReadKey();
            Console.Clear();

            // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            #endregion

            #region Task 4.
            //Написать программу обмена значениями двух переменных.
            // а) с использованием третьей переменной;
            int v = 10;
            int j = 15;
            int c = v;
            v = j;
            j = c;

            // б) *без использования третьей переменной. 
            int a01 = 1;
            int b01 = 2;
            a01 = a01 + b01;
            b01 = a01 - b01;
            a01 = a01 - b01;

            #endregion

            #region TAsk 5. 
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.Title = "Имя, фамилия, город проживания";
            Console.WriteLine("Виктория Ахмадеева, город Челябинск");
            Console.ReadKey();
            Console.Clear();
        }

        // б) Сделать задание, только вывод организуйте в центре экрана
        private static void Print(string g)
        {
            Console.SetCursorPosition(Convert.ToInt32(Console.WindowWidth / 2), Convert.ToInt32(Console.WindowHeight / 2));
            Print(g);
            Console.WriteLine(g);
            Console.ReadKey();
            Console.Clear();
        }

        // в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

        #endregion




    }
}

