using System;


namespace Generalizations
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу в которой создайте обобщенный класс книга(Book). Класс Book должен
        //содержать универсальный параметра типа T(Book &lt; T&gt;). В теле класса создайте два закрытых
        //поля: Name – имя книги(private string Name) и Price – (обобщенныйтип) цена книги
        //(private T Price). Также создайте свойства для доступа к выше описанным полям.После чего
        //создайте метод Show() который будет вывод название книги и ее цену.В методе Main()
        //создайте экземпляры обобщенного типа, где Т это int и где Т это double.
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string NameM = Console.ReadLine();
            Console.Write("Введите цену книги: ");
            int temp = int.Parse(Console.ReadLine());
            Book<int> book = new Book<int>();
            book.Set(temp, NameM);
            book.Show();
            Console.Write("Введите название книги: ");
            string NameM1 = Console.ReadLine();
            Console.Write("Введите цену книги: ");
            double temp1 = double.Parse(Console.ReadLine());
            Book<double> book1 = new Book<double>();
            book1.Set(temp1, NameM1);
            book1.Show();
        }
    }
    class Book <T>
    {
        private string Name;
        private T Price; 
    
        public void Set(T number,string NameM){
            Name = NameM;
            Price = number;
        }
        public void Show(){
            Console.WriteLine("Название книги - " + Name);
            Console.WriteLine("Цена книги - " + Price);
        }
    }
}
