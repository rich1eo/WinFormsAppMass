using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMass
{
    public partial class Form1 : Form
    {
        private int[] a;
        private int size = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void sizemas_TextChanged(object sender, EventArgs e)
        {
            if (sizemas.Text != "")
            {
                size = Convert.ToInt32(sizemas.Text);
            }
            else
            {
                size = 5;
            }
        }
        
        private void reset_Click(object sender, EventArgs e)
        {
            sizemas.Clear();
            MassivIn.Clear();
        }

        private void SearchMax_Click(object sender, EventArgs e)
        {
            int sum = 1; // счетчик произведения элементов
            int max = Math.Abs(a[0]); // задаем переменную равную модулю первого элемента матрицы 
            //для поиска максимального по модулю элемента массива, если удовлетворяет условию
            for (int i = 0; i < size; i++) { // цикл для расчета произведения массива
                sum *= a[i];
            }
            if (sum > 50) { // если больше 50 - поиск максимального по модулю элемента
                for (int i = 1; i < size; i++){
                    if (Math.Abs(a[i]) > max)
                        max = Math.Abs(a[i]);
                }

                Maxelem.Text = max.ToString();
            }
            else
            {
                Maxelem.Text = "меньше 50";
            }
        }

        private void randomElem_Click(object sender, EventArgs e)
        {
            MassivIn.Clear();
            sizemas.Text = size.ToString();
            a = new int[size];
            Random b = new Random();
            MassivIn.Text += "| ";
            for (int i = 0; i < size; ++i)
            {
                a[i] = b.Next(10);
                MassivIn.Text+=Convert.ToString(a[i])+ " | ";
            }

        }
    }
}