using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OP_Lub6
{

    public partial class FuncForm : Form
    {
        private int attleft;
        private double correctans;
        private bool isGame = false;
        private double a1;
        private double a2;



        public FuncForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out attleft) || attleft <= 0)
            {
                MessageBox.Show("Введите корректное число попыток (больше 0)!", "Ошибка");
                return;
            }
            if (!double.TryParse(textBox2.Text, out a1))
            {
                MessageBox.Show("Ошибка ввода значения альфа!", "Ошибка!");
                return;
            }
            else
            {
                double.TryParse(textBox2.Text, out a1);
            }
            if (!double.TryParse(textBox3.Text, out a2))
            {
                MessageBox.Show("Ошибка ввода значения бета!", "Ошибка!");
                return;
            }
            else
            {
                double.TryParse(textBox2.Text, out a2);
            }
            label5.Text = $"Осталось попыток: {attleft}";
            label7.Text = $"Вычислите значение функции при a = {a1}, b = {a2}";
            textBox4.Visible = true;
            correctans = GuessGame.func(a1, a2);
            isGame = true;
            textBox4.Clear();
            textBox4.Enabled = true;
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isGame)
            {
                MessageBox.Show("Сначала нажмите «Начать игру»!", "Внимание");
                return;
            }
            if (!double.TryParse(textBox4.Text, out double userAnswer))
            {
                MessageBox.Show("Введите число! Дробную часть отделяйте запятой.", "Ошибка ввода");
                return;
            }
            if (Math.Abs(correctans - userAnswer) < 0.01)
            {
                MessageBox.Show("Поздравляем! Вы угадали правильный ответ!", "Победа");
                EndGame();
            }
            else
            {
                attleft--;
                label5.Text = $"Осталось попыток: {attleft}";

                if (attleft > 0)
                {
                    MessageBox.Show("Неверно! Попробуйте ещё раз.", "Ошибка");
                }
                else
                {
                    MessageBox.Show($"Попытки закончились! Правильный ответ был: {correctans}", "Проигрыш");
                    EndGame();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void EndGame()
        {
            isGame = false;
            textBox4.Enabled = false;
            button2.Enabled = false;
        }
    }
}
