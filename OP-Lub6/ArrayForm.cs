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
        private bool shellbutton = false;

        private double AverageValue;
        private int[] mass;
        private int[] mass2;
        private int[] mass3;
        private long shelltimer;
        private long inptimer;



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
                mass = new int[ArrayLen];
                Random rnd = new Random();
                for (int i = 0; i < ArrayLen; i++)
                {
                    mass[i] = rnd.Next(-100, 100);
                }
                mass2 = ArrayWork.copyarr(mass);
                mass3 = ArrayWork.copyarr(mass);
                Stopwatch atimer = Stopwatch.StartNew();
                ArrayWork.inpsort(mass2);
                atimer.Stop();
                inptimer = atimer.ElapsedMilliseconds;
                Stopwatch btimer = Stopwatch.StartNew(); //inptimer.ElapsedMilliseconds
                ArrayWork.shellsort(mass3);
                btimer.Stop();
                shelltimer = btimer.ElapsedMilliseconds;
                MaxValue = ArrayWork.maxinarr(mass);
                MinValue = ArrayWork.mininarr(mass);
                AverageValue = ArrayWork.avginarr(mass);
                FillGrid(dataGridView1, "Исходный массив", mass);

            }
        }
        private void FillGrid(DataGridView grid, string header, int[] array)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            if (grid.Columns.Count == 0)
            {
                grid.Columns.Add("ColValue", header);
            }
            foreach (int i in array)
            {
                grid.Rows.Add((object)i);
            }
            grid.ResumeLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mass3 != null)
            {
                FillGrid(dataGridView3, "Сортировка Шелла", mass3);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mass2 != null)
            {
                FillGrid(dataGridView2, "Сортировка вставками", mass2);
            }
        }
    }
}
