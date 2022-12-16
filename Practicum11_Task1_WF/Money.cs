using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum11_Task1_WF
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
        public string outInfo()
        {
            return $"Номинал купюры - {first}\nКоличество купюр - {second}";
        }

        public string isEnoughMoney(int sum)
        {
            if (first * second >= sum) return "Бюджета хватит на покупку товара";
            else return "Бюджета не хватит на покупку товара";
        }

        public string quantityOfGoods(int price, int sum)
        {
            if (sum >= price)
            {
                return $"Можно приобрести {sum / price} шт. товара";
            }
            else return "Товар нельзя приобрести так как его цена превышает денежную сумму";
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
