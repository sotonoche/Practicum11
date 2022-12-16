using System;

namespace Practicum11
{
    internal class Money
    {
        //поля класса
        private int first;//номинал купюры
        private int second;//количество купюр

        //конструктор класса
        public Money(int nomination, int value)
        {
            first = nomination;
            second = value;
        }

        //методы класса
        public void outInfo()
        {
            Console.WriteLine($"Номинал купюры - {first}");
            Console.WriteLine($"Количество купюр - {second}");
        }

        public void isEnoughMoney(int sum)
        {
            if (first * second >= sum) Console.WriteLine("Бюджета хватит на покупку товара");
            else Console.WriteLine("Бюджета не хватит на покупку товара");
        }

        public void quantityOfGoods(int price, int sum)
        {   
            if (sum >= price)
            {
                Console.WriteLine($"Можно приобрести {sum/price} шт. товара");
            }
            else Console.WriteLine("Товар нельзя приобрести так как его цена превышает денежную сумму");
        }

        //свойства класса
        public int First
        {
            get { return first; }
            set { first = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public int Sum
        {
            get { return first * second; }
        }
    }
}
