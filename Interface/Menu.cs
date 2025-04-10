using System.Security.Cryptography;

namespace Interface
{
    public partial class ProjectSort : Form
    {
        List<int> fileContent = new List<int>(); // список чисел на обработку
        public ProjectSort()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Taskform("Сортировка слиянием").ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Taskform("Сортировка черпаками (2 элемента)").ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Taskform("Пузырьковая сортировка").ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Taskform("Сортировка вставкой").ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Taskform("Сортировка слиянием").ShowDialog();
        }

        private void ProjectSort_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Taskform("Сортировка черпаками (3 элемента)").ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Taskform("Сортировка черпаками (4 элемента)").ShowDialog();
        }
    }
}

