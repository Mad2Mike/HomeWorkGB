using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine(" ");
            Console.WriteLine("Привет! Заполним анкету. как тебя зовут?");
            string firstName = Console.ReadLine();
            Console.WriteLine("А какая у тебя фамилия?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Твой вес (кг)?");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Твой рост (см)?");
            double growth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Тебя зовут {firstName} {lastName}, тебе {age}, твой вес {weight} кг, а рост {growth} см ");
            Console.WriteLine("Тебя зовут {0} {1}, тебе {2}, твой вес {3} кг, а рост {4} см", firstName, lastName, age, weight, growth);
            Console.WriteLine("Тебя зовут " + firstName + " " + lastName + ", тебе " + age + ", твой вес " + weight + " кг, а рост " + growth + " см");

            //Задание 2.
            Console.WriteLine(" ");
            Console.WriteLine("Задание 2");
            Console.WriteLine(" ");

            double I = weight / (growth * growth * 0.0001);

            Console.WriteLine($"{Math.Round(I, 2)}");

            //Задание 3.
            Console.WriteLine(" ");
            Console.WriteLine("Задание 3");
            Console.WriteLine(" ");
            Exercise3();

            Console.ReadLine();




        }
        static void Exercise3()
        {
            Console.WriteLine("Введите координату х1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату х2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(" ");
            Console.WriteLine($"Расстояние между точками: {Math.Round(r, 2)}");
        }
    }
    
}
