namespace OP_Lub6
{
    partial class FuncForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 89);
            label1.Name = "label1";
            label1.Size = new Size(266, 15);
            label1.TabIndex = 0;
            label1.Text = "f = Sqrt((sin^2 a + cos^3 b) / (sin^3 a - cos^2 b))";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 130);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите кол-во доступных попыток";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 183);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Значение альфа";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 234);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 6;
            label4.Text = "Значение бета";
            // 
            // button1
            // 
            button1.Location = new Point(325, 353);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 7;
            button1.Text = "Начать игру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 383);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 286);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(100, 304);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            textBox4.Visible = false;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(325, 302);
            button2.Name = "button2";
            button2.Size = new Size(121, 45);
            button2.TabIndex = 11;
            button2.Text = "Проверить ответ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FuncForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 410);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FuncForm";
            Text = "Игра по отгадыванию ответа значения функции";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label7;
        private TextBox textBox4;
        private Button button2;
    }
}