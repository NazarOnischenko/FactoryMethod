using System;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Deliver deliver = new DeliverOfFood("Олександр Сочинський");
            Product product = deliver.ToDeliver();

            deliver = new DeliverOfAppliances("Василь Гензерук");
            product = deliver.ToDeliver();

            deliver = new DeliverOfClothing("Максим Марущак");
            product = deliver.ToDeliver();

            deliver = new DeliverOfFurniture("Назар Колвеліс");
            product = deliver.ToDeliver();
        }
    }
}
