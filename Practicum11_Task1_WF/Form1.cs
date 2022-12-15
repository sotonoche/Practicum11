using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum11_Task1_WF
{
    public partial class Form1 : Form
    {
        Money money;
        int nomination, value, sum, price;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = money.quantityOfGoods(price);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                money.First = (int)numericUpDown5.Value;
                money.Second = (int)numericUpDown6.Value;
                if (money.First <= 0 || money.Second <= 0) throw new Exception("Значение не может быть меньше или равно нулю!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show($"Значение номинала равно {money.First}\nЗначение кол-ва купюр равно {money.Second}\n" +
                $"Сумма денег равна {money.Sum}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                nomination = (int)numericUpDown1.Value;
                value = (int)numericUpDown2.Value;
                sum = (int)numericUpDown3.Value;
                price = (int)numericUpDown4.Value;
                if (nomination <= 0 || value <= 0 || sum <= 0 || price <= 0) throw new Exception("Значение не может быть меньше или равно нулю!");
                money = new Money(nomination, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = money.outInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = money.isEnoughMoney(sum);
        }
    }
}
