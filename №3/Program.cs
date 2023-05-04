using System;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу в которой создайте класс калькулятор(Calculator). Класс Calculator должен
        //содержать два универсальных параметра типа T1, T2(Calculator &lt; T1, T2&gt;). В теле класса создайте
        //методы для сложения, вычитания и умножения, которые в качестве аргументов должны
        //принимать T1, T2, и возвращать тип double (можно использовать класс Convert или приведение типов)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator<double, double> calculator = new Calculator<double, double>();
            calculator.Add(10, 5);
        }
    }
    class Calculator<T1,T2> 
    {
        private double A;
        private double B;
        public void Add(T1 t1,T2 t2){
            A = t1;
            B = t2;
            Console.WriteLine("Добавил - " + (A + B));
            //Нужна подсказка и я исправлю тут )
            //Напишите в телеграмме мне @seller_ip
        }
    }
}
