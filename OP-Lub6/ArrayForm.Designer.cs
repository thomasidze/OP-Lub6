namespace OP_Lub6
{
    partial class ArrayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Введите длину:";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 56);
            button2.Name = "button2";
            button2.Size = new Size(121, 48);
            button2.TabIndex = 2;
            button2.Text = "Создать массив с указанной длиной";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 125);
            button3.Name = "button3";
            button3.Size = new Size(121, 55);
            button3.TabIndex = 3;
            button3.Text = "Создать массив со стандартной длиной (10)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(57, 107);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "или";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(127, 370);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(10, 204);
            button4.Name = "button4";
            button4.Size = new Size(123, 55);
            button4.TabIndex = 6;
            button4.Text = "Выделить цветом min (green) и max (red)";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(327, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(127, 370);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(488, 27);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(127, 370);
            dataGridView3.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(12, 328);
            button5.Name = "button5";
            button5.Size = new Size(92, 47);
            button5.TabIndex = 9;
            button5.Text = "Сортировка Шелла";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 275);
            button6.Name = "button6";
            button6.Size = new Size(92, 47);
            button6.TabIndex = 10;
            button6.Text = "Сортировка вставками";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ArrayForm
            // 
            ClientSize = new Size(701, 422);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Name = "ArrayForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button5;
        private Button button6;
    }
}