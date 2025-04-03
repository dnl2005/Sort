using System.Linq.Expressions;

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
        /// ����� ��� ������ � ������ �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath; //���� � �����
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // ����� � ������� ���������� �����
                openFileDialog.Filter = "��������� ����� .txt|*.txt"; // ������ ������

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // ��������� ���� � �����
                        filePath = openFileDialog.FileName;
                        // ������ �����
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            string line;
                            List<int> lineContent = new List<int>();
                            while ( (line = reader.ReadLine()) != null)
                            {
                                lineContent.AddRange(line.Split(",").Select(s => int.Parse(s)));
                                fileContent.AddRange(lineContent);
                                lineContent.Clear();
                            }
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("������ ������ �����.");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("������������ ������ ��� ���������� � �����.");
                    }
                }
            }
            
        }
    }
}
