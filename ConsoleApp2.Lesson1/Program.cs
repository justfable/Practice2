using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }
        /// <summary>
        /// Написать приложение, которое выведет на экран Ваше имя и фамилию.
        /// (Жду что у вас будет приложение, которое я сам запущу и где у 
        /// меня попросят ввести ФИО, после я нажму Enter и мне выдастся 
        /// сообщение – «Приветствую тебя - ФИО»)
        /// </summary>
        static void Example1()
        {
            string fName;
            Console.Write("Введите Ваше ФИО");
            fName = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + fName);
        }
        /// <summary>
        /// Написать приложение, которое ожидает ввода нескольких чисел 
        /// и выводит на экран их сумму. (Так же как и в предыдущем примере, 
        /// только с цифрами. Мы проходили как можно из строки перевести в 
        /// число.)
        /// </summary>
        static void Example2()
        {
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);    

            Console.WriteLine(a + b);
        }
        /// <summary>
        /// 3.	Дано расстояние в сантиметрах. 
        /// Найти число полных метров в нем
        /// </summary>
        static void Example3()
        {
            int sm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sm / 100);
        }

        /// <summary>
        /// 4.	С некоторого момента прошло 234 дня. 
        /// Сколько полных недель прошло за этот период?
        /// </summary>
        static void Example4()
        {
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(w / 7);
        }
        /// <summary>
        /// 5.	Дано двузначное число. Найти:
        /// a.число десятков в нем;
        /// b.число единиц в нем;
        /// c.сумму его цифр;
        /// d.произведение его цифр
        /// </summary>
        static void Example5()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num >= 10 || num <= 99)
            {
                int a = num / 10;
                int b = num % 10;
                int c = a + b;
                int d = a * b;
            }
            Console.WriteLine("a\nb\nc\nd");
        }
        /// <summary>
        /// 6.	Вычислить значение логического выражения при следующих 
        /// значениях логических величин А, В и С:
        /// А = Истина, В = Ложь, С = Ложь:
        /// a.А или В; 
        /// b.А и В; 
        /// c.В или С.
        /// </summary>
        static void Example6()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A & B);
            Console.WriteLine(B || C);
        }
        /// <summary>
        /// 7.	Даны радиус круга и сторона квадрата. 
        /// У какой фигуры площадь больше?
        /// </summary>
        static void Example7()
        {
            int R = Convert.ToInt32(Console.ReadLine());
            int A = Convert.ToInt32(Console.ReadLine());
            double Sr = Math.PI * R * R;
            double Sa = 4 * A;

            if(Sr > Sa)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else if(Sr == Sa)
            {
                Console.WriteLine("Площади одинаковые");
            }
            else
            {
                Console.WriteLine("Площадб квадрата больше");
            }
        }

        /// <summary>
        /// Даны объемы и массы двух тел из разных материалов. 
        /// Материал какого из тел имеет большую плотность?
        /// </summary>
        static void Example8()
        {
            int m1 = 0;
            int m2 = 0;
            int V1 = 0;
            int V2 = 0;

            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out V1);
            int.TryParse(Console.ReadLine(), out V2);

            double p1 = m1 / V1;
            double p2 = m2 / V2;

            if(p1 > p2) {
                Console.WriteLine("Материал p1 плотнее");
            }
            else
            {
                Console.WriteLine("Материал p2 плотнее");
            }
        }

        /// <summary>
        /// 10.	 Напечатать "столбиком": 
        /// a.все целые числа от 20 до 35;
        /// b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
        /// c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a< 50);
        /// d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).

        /// </summary>
        static void Example10()
        {
            ///a
            for(int i = 20;  i <= 35;  i++)
            {
                Console.WriteLine(i);      
            }

            ///b
            int b = 0;
            int.TryParse(Console.ReadLine() , out b);   
            for(int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
        }


        static void Example12() {
            int R = 0;
            int.TryParse(Console.ReadLine(), out R);

            double l = Math.PI * 2 * R;
            double S = Math.PI * R * R;
        }

        /// <summary>
        /// 16.	Дано четырехзначное число. Найти:
        /// a.сумму его цифр;
        /// b.произведение его цифр.
        /// </summary>
        static void Example16()
        {
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);

            if(num >= 1000 & num <= 9999)
            {
                int num1 = num / 1000;
                int num2 = (num / 100) % 10;
                int num3 = (num % 100) / 10;
                int num4 = num % 10;

                Console.WriteLine(num1 + num2 + num3 + num4);
                Console.WriteLine(num1 * num2 * num3 * num4);
            }
        }

        /// <summary>
        /// 17.	В трехзначном числе x зачеркнули его вторую цифру. 
        /// Когда к образованному при этом двузначному числу справа 
        /// приписали вторую цифру числа x, то получилось число 456. 
        /// Найти число x.
        /// </summary>
        static void Example17()
        {
            int num = 456;
            int x = num % 10;
        }

    }
}
