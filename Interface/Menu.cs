using System.Security.Cryptography;

namespace Interface
{
    public partial class ProjectSort : Form
    {
        List<int> fileContent = new List<int>(); // ������ ����� �� ���������
        public ProjectSort()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Taskform("���������� ��������").ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Taskform("���������� ��������� (2 ��������)").ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Taskform("����������� ����������").ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Taskform("���������� ��������").ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Taskform("���������� ��������").ShowDialog();
        }

        private void ProjectSort_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Taskform("���������� ��������� (3 ��������)").ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Taskform("���������� ��������� (4 ��������)").ShowDialog();
        }
    }
}

