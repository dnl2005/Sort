namespace Interface
{
    public partial class ProjectSort : Form
    {
        public ProjectSort()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Метод для выбора и чтения файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> fileContent = new List<int>(); // список чисел на обработку
            string filePath; //путь к файлу

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // папка с которой начинается выбор
                openFileDialog.Filter = "Текстовые файлы .txt|*.txt"; // фильтр файлов

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // получение пути к файлу
                        filePath = openFileDialog.FileName;
                        // чтение файла
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            string line;
                            while ( (line = reader.ReadLine()) != null)
                            {
                                //вопрос в том, какой формат записи будет ожидаться в файле
                                //1, 2, 3
                                //или
                                //1 2 3 
                            }
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Ошибка чтения файла.");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректные данные для сортировки в файле.");
                    }
                }
            }
            
        }
    }
}
