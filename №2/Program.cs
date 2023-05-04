using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу в которой создайте класс MyClass&lt;T&gt;, содержащий статический фабричный
        //метод - T FacrotyMethod(), который будет порождать экземпляры типа, указанного в качестве
        //параметра типа(указателя места заполнения типом – Т).
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
