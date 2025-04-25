using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class SortResultsForm : Form
    {
        private DataGridView dataGridView;

        public SortResultsForm()
        {
            InitializeComponent();
            InitializeTable();
            FormClosing += SortResultsForm_FormClosing; //чтобы при нажатии на крестик вызывался метод SortResultsForm_FormClosing
        }
        // Перехват закрытия — скрываем
        private void SortResultsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void InitializeTable()
        {
            dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnCount = 5
            };

            dataGridView.Columns[0].Name = "Метод сортировки";
            dataGridView.Columns[1].Name = "Сложность (O)";
            dataGridView.Columns[2].Name = "Кол-во элементов";
            dataGridView.Columns[3].Name = "Время (мс)";
            dataGridView.Columns[4].Name = "Затраты по памяти";

            Controls.Add(dataGridView);
        }



        // Метод для добавления строки
        public void AddSortResult(SortResult result)
        {
            dataGridView.Rows.Add(result.Method, result.Complexity, result.ElementCount,
                                  result.TimeInSeconds, result.MemoryComplexity);
        }
    }
    public class SortResult
    {
        public string Method { get; set; }
        public string Complexity { get; set; }
        public int ElementCount { get; set; }
        public float TimeInSeconds { get; set; }
        public string MemoryComplexity { get; set; }
    }


}
