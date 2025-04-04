
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
            fileContent.Clear();
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
                            List<int> lineContent = new List<int>(); // список для чисел текущей строки
                            while ( (line = reader.ReadLine()) != null)
                            {
                                // разбиваем line на подстроки, преобразуем в тип int
                                // и добавляем в lineContent
                                lineContent.AddRange(line.Split(",").Select(s => int.Parse(s)));
                                fileContent.AddRange(lineContent);
                                lineContent.Clear();
                            }
                        }
                        if (fileContent.Count==0)
                        {
                            throw new Exception("Файл пуст");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Файл пуст");
                    }
                }
            }
            
        }
    }
}
