using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца. 
             Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
            Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса,
            параметризированного различными типам. Заполнить его поля и вывести информацию об экземпляре класса на печать.*/
            string number = "001";
            decimal balance = 456.56M;
            string owner = "Котофей Иваныч";
            int number2 = 002;
            decimal balance2 = 513.02M;
            string owner2 = "Eрофей Семеныч";
            BankAccount<string> account = new BankAccount<string>();
            account.Record(number, balance, owner);
            account.Read();
            Console.WriteLine();
            BankAccount<int> account2 = new BankAccount<int>();
            account2.Record(number2, balance2, owner2);
            account2.Read();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        T Number { get; set; }
        decimal Balance { get; set; }
        string Owner { get; set; }
        public void Record(T number, decimal balance, string owner)
        {
            Number = number;
            Balance = balance;
            Owner = owner;
        }
        public void Read()
        {
            Console.WriteLine("Номер счета: {0}",Number);
            Console.WriteLine("Баланс: {0}",Balance);
            Console.WriteLine("Владелец: {0}",Owner);
        }
    }
}
