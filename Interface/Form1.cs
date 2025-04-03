
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
        /// ����� ��� ������ � ������ �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            fileContent.Clear();
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
                            List<int> lineContent = new List<int>(); // ������ ��� ����� ������� ������
                            while ( (line = reader.ReadLine()) != null)
                            {
                                // ��������� line �� ���������, ����������� � ��� int
                                // � ��������� � lineContent
                                lineContent.AddRange(line.Split(",").Select(s => int.Parse(s)));
                                fileContent.AddRange(lineContent);
                                lineContent.Clear();
                            }
                        }
                        if (fileContent.Count==0)
                        {
                            throw new Exception("���� ����");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("���� ����");
                    }
                }
            }
            
        }
    }
}
