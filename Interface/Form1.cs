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
        /// ����� ��� ������ � ������ �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> fileContent = new List<int>(); // ������ ����� �� ���������
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
                            while ( (line = reader.ReadLine()) != null)
                            {
                                //������ � ���, ����� ������ ������ ����� ��������� � �����
                                //1, 2, 3
                                //���
                                //1 2 3 
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
