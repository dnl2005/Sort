
using System.Security.Cryptography;

namespace Interface
{
    public partial class ProjectSort : Form
    {
        public SortResultsForm resultsForm;

        public ProjectSort()
        {
            InitializeComponent();
            resultsForm = new SortResultsForm();
            resultsForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Показать форму (если скрыта)
            if (!resultsForm.Visible)
                resultsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TaskForm("Пузырьковая сортировка", resultsForm).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировка вставкой", resultsForm).ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TaskForm("сортировка Хоара", resultsForm).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new TaskForm("Задача Дейкстры", resultsForm).ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировочная шляпа", resultsForm).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировка слиянием", resultsForm).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TaskForm("Быстрая сортировка", resultsForm).ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировка черпаками", resultsForm).ShowDialog();
        }

        private void QuestionB_Click(object sender, EventArgs e)
        {
            new TermsOfUse().ShowDialog();
        }


    }
}
