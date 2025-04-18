
using System.Security.Cryptography;

namespace Interface
{
    public partial class ProjectSort : Form
    {
        SortResultsForm resultsForm;

        public ProjectSort()
        {
            InitializeComponent();
            resultsForm = new SortResultsForm();
            resultsForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortResult result = new SortResult
            {
                Method = "QuickSort",
                Complexity = "O(n log n)",
                ElementCount = 10000,
                TimeInSeconds = 0.1523f,
                MemoryComplexity = "O(log n)"
            };

            // Показать форму (если скрыта)
            if (!resultsForm.Visible)
                resultsForm.Show();

            // Добавить результат
            resultsForm.AddSortResult(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TaskForm("Пузырьковая сортировка").ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировка вставкой").ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TaskForm("сортировка Хоара").ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new TaskForm("Задача Дейкстры").ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировочная шляпа").ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировка слиянием").ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TaskForm("Быстрая сортировка").ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new TaskForm("Сортировка черпаками").ShowDialog();
        }

        private void QuestionB_Click(object sender, EventArgs e)
        {
            new TermsOfUse().ShowDialog();
        }


    }
}
