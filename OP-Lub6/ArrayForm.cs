using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OP_Lub6
{
    public partial class ArrayForm : Form
    {
        private int ArrayLen;
        private int MaxValue;
        private int MinValue;

        private double AverageValue;

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out ArrayLen) || ArrayLen <= 0)
            {
                MessageBox.Show("Ошибка ввода значения!", "Ошибка!");
                return;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                int[] mass = new int[ArrayLen];
                Random rnd = new Random();
                for (int i = 0; i < ArrayLen; i++)
                {
                    mass[i] = rnd.Next(-100, 100);
                }
                int[] mass2 = ArrayWork.copyarr(mass);
                int[] mass3 = ArrayWork.copyarr(mass);
                Stopwatch inptimer = Stopwatch.StartNew();
                ArrayWork.inpsort(mass2);
                inptimer.Stop();
                Stopwatch shelltimer = Stopwatch.StartNew(); //inptimer.ElapsedMilliseconds
                ArrayWork.shellsort(mass3);
                shelltimer.Stop();
                MaxValue = ArrayWork.maxinarr(mass);
                MinValue = ArrayWork.mininarr(mass);
                AverageValue = ArrayWork.avginarr(mass);
                dataGridView1.SuspendLayout();
                dataGridView1.Rows.Clear();
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("ColValue", "Исходный массив");
                }
                foreach (int i in mass)
                {
                    dataGridView1.Rows.Add((object)i);
                }
                dataGridView1.ResumeLayout();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
