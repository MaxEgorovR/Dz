namespace Dz
{
    public partial class Form1 : Form
    {
        private string userFullName = string.Empty;
        private DateTime userBirthDate;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ФИО: {userFullName}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Время сейчас: {DateTime.Now}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Дата рождения: {userBirthDate}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button2_Click(sender, e);
            button3_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userFullName = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            userBirthDate = dateTimePicker1.Value;
        }
    }
}
