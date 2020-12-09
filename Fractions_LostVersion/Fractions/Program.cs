using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction1 f = new Fraction1(3, 5);
            Fraction1 f1 = new Fraction1(2, 4);
            Fraction1 f2 = new Fraction1(-2, 4);
            Fraction1 f3 = new Fraction1(2, -4);
            Fraction1 f4 = new Fraction1(-2, -4);

            Console.WriteLine("\nТест Суммирование");
            PrintResultOperation(f, f1, "+");
            PrintResultOperation(f, f, "+");
            PrintResultOperation(f2, f, "+");
            PrintResultOperation(f3, f4, "+");

            Console.WriteLine("\nТест Вычитание");
            PrintResultOperation(f, f1, "-");
            PrintResultOperation(f, f, "-");
            PrintResultOperation(f2, f, "-");
            PrintResultOperation(f3, f4, "-");

            Console.WriteLine("\nТест - умножение");
            PrintResultOperation(f, f1, "*");
            PrintResultOperation(f, f, "*");
            PrintResultOperation(f2, f, "*");
            PrintResultOperation(f3, f4, "*");

            Console.WriteLine("\nТест деление");
            PrintResultOperation(f, f1, "/");
            PrintResultOperation(f, f, "/");
            PrintResultOperation(f2, f, "/");
            PrintResultOperation(f3, f4, "/");


            //Console.WriteLine(0/f4.Denumerator);
            Console.ReadKey();
        }

        public static void PrintResultOperation(Fraction1 f1, Fraction1 f2, string operation)
        {
            switch(operation)
            {
                case "+":f1.Sum(f1, f2);break;
                case "-":f1.Subtruction(f1,f2);break;
                case "*":f1.Multiplication(f1,f2);break;
                case "/":f1.Division(f1,f2);break;
            }
            Console.WriteLine($"{f1.OperationName} дробей {f1} и {f2} = {f1.getResult().Numerator}/{f1.getResult().Denumerator}");
        }
    }
}
/*
 1.Прочитать и выучить файл приложения
2. Написать класс обыкновенной дроби, содержащий следующие поля, доступные для чтения и записи:
2.1 Числитель дроби
2.2 Знаменатель дроби
2.3 Значение дроби типа double
В сеттере знаменателя дроби обязательно выполнять проверку на 0, при возможности воспользоваться механизмом исключений, а так же 
класс должен содержать следующие методы:
2.4 Сложение дробей
2.5 Вычитание дробей
2.6 Произведение дробей
2.7 Частное дроби
Так же класс дроби должен содержать следующий приватный метод:
2.8 Сокращение дроби
Так же класс дроби должен содержать следующие конструкторы:
2.9 Конструктор без параметров(в нём числителю и знаменателю присваиваются значения равные 1)
2.10 Конструктор с двумя параметрами( параметры два целых числа - числитель и знаменатель)
В конструкторе 2.10 так же обязательно реализовать проверку числа на 0, так же желательно использовать механизм исключений. Так же класс 
должен содержать следующией перегруженный метод:
2.11 ToString, в котором дробь выводится в виде "{числитель}/{знаменатель}
При выполнении арифметических операций, конструкторов и изменений числителя или знаменателя дробь обязательно должна сокращаться. Дроби выводятся 
только в сокращённом виде. Так же крайне важно не допускать по возможности дублирования кода, при черезмерном дублировании кода будут 
сниматься баллы за работу(то есть возмиожно выделение дополнительных методов или даже классов, не указанных в задании).
 */
