
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
            new TermsOfUse().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Taskform("ѕузырькова€ сортировка").ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ProjectSort_Load(object sender, EventArgs e)
        {

        }
    }
}

