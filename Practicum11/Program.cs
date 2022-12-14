using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nomination, value, sum, price;
            while (true)
            {
                try
                {
                    Console.Write("Введите номинал купюры: ");
                    nomination = int.Parse(Console.ReadLine());
                    Console.Write("Введите количество купюр: ");
                    value = int.Parse(Console.ReadLine());
                    Console.Write("Введите сумму закупки товара: ");
                    sum = int.Parse(Console.ReadLine());
                    Console.Write("Введите стоимость товара: ");
                    price = int.Parse(Console.ReadLine());
                    if (nomination <= 0 || value <= 0 || sum <= 0 || price <= 0) throw new Exception("Значение не может быть меньше или равно нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }   
            }
            Console.WriteLine("------------------------------------------------------------");
            Money money = new Money(nomination, value);

            money.outInfo();
            Console.WriteLine("------------------------------------------------------------");
            money.isEnoughMoney(sum);
            Console.WriteLine("------------------------------------------------------------");
            money.quantityOfGoods(price);
            Console.WriteLine("------------------------------------------------------------");
            while (true)
            {
                try
                {
                    Console.Write("Введите значение номинала: ");
                    money.First = int.Parse(Console.ReadLine());
                    Console.Write("Введите значение количества купюр: ");
                    money.Second = int.Parse(Console.ReadLine());
                    if (money.First <= 0 || money.Second <= 0) throw new Exception("Значение не может быть меньше или равно нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Значение номинала равно {money.First}, значение кол-ва купюр равно {money.Second}\n" +
                $"Сумма денег равна {money.Sum}");
        }
    }
}
