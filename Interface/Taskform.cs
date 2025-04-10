using Microsoft.VisualBasic;
using ClassLibrary;
namespace Interface
{
    public partial class Taskform : Form
    {
        private string taskName;
        private string input;
        public Taskform(string taskName)
        {
            InitializeComponent();
            this.taskName = taskName;
            label4.Text = "Выбрано: " + taskName;
            // 1. Установите эти свойства для Label (можно в дизайнере)
            label4.AutoSize = true;
            label4.Anchor = AnchorStyles.None;
            label4.TextAlign = ContentAlignment.MiddleCenter;


            // 3. В конструкторе формы или при загрузке:
            CenterLabel();
            this.Resize += (s, e) => CenterLabel();
        }

        // 2. Этот метод центрирует текст
        private void CenterLabel()
        {
            label4.Left = (this.ClientSize.Width - label4.Width) / 2;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = StringToArray();
            if (numbers != null)
            {
                switch (taskName)
                {
                    case "Пузырьковая сортировка":
                        numbers = Sorts.BubbleSort(numbers);
                        PrintArray(numbers);
                        break;
                    case "Сортировка вставкой":
                        numbers = Sorts.InsertionSort(numbers);
                        break;
                    case "Сортировка слиянием":
                        numbers = Sorts.MergeSort(numbers);
                        break;
                    case "Быстрая сортировка":
                        numbers = Sorts.QuickSort(numbers);
                        break;
                    case "Сортировка черпаками (2 элемента)":
                        numbers = Sorts.BubbleSort(numbers);
                        break;
                    case "Сортировка черпаками (3 элемента)":
                        numbers = Sorts.BubbleSort(numbers);
                        break;
                    case "Сортировка черпаками (4 элемента)":
                        numbers = Sorts.BubbleSort(numbers);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Введите корректный масив чисел для сортировки. См. справку");
            }
        }
        private void PrintArray(int[] list)
        {
            string output = "";

            for (int i = 0; i < list.Length; i++)
            {
                output += list[i];

                if (i != list.Length - 1)
                    output += ", ";
            }

            textBox2.Text = output;
        }
        private int[] StringToArray()
        {
            try
            {
                if (input == null)
                    throw new Exception();
                int[] numbers = input.Split(',')
                 .Select(s =>        // использование лямбда-выражения для обработки массива строк
                                     // s - каждая подстрока в массиве
                    int.Parse(s.Trim()) // обработка s: удаление лишних пробелов 
                                        // и преобразование в число
                ).ToArray(); // преобразование в массив
                return numbers;
            }
            catch (FormatException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
