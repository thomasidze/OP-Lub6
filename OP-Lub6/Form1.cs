namespace OP_Lub6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Подтверждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncForm funcwindow = new FuncForm();
            funcwindow.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            About abputwindow = new About();
            abputwindow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayForm array = new ArrayForm();
            array.ShowDialog();
        }
    }
}
