namespace Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "��������...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) {
                printPreviewDialog1.ShowDialog();
            }
            toolStripStatusLabel1.Text = "������ ���� ������...";
            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.Text = "������ ������";
            }else textBox1.Text = comboBox1.SelectedIndex.ToString();
        }
    }
}