using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class TaskForm : Form
    {
        private string taskName;
        private string input;

        public TaskForm(string taskName)
        {
            InitializeComponent();
            this.taskName = taskName;
            Title.Text = taskName;
            Title.AutoSize = true;
            Title.Anchor = AnchorStyles.None;
            Title.TextAlign = ContentAlignment.MiddleCenter;

            CenterTitle();
            this.Resize += (s, e) => CenterTitle();
        }

        private void CenterTitle()
        {
            Title.Left = (this.ClientSize.Width - Title.Width) / 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = StringToArray();

            if (numbers != null)
            {
                switch (taskName)
                {
                    case "Пузырьковая сортировка":
                        numbers = Sorts.BubbleSort(numbers);
                        break;
                    case "Сортировка вставкой":
                        numbers = Sorts.InsertionSort(numbers);
                        break;
                    case "Сортировка слиянием":
                        numbers = Sorts.MergeSort(numbers);
                        break;
                    case "Быстрая сортировка":
                        numbers = Sorts.QuickSort(numbers, 0, numbers.Length - 1);
                        break;
                    case "Сортировка черпаками":
                        numbers = Sorts.BucketSort(numbers);
                        break;
                    case "сортировка Хоара":
                        bool isUnic = CheckOnUnic(numbers, 2);
                        if(isUnic)
                        {
                            numbers = Sorts.TwoWayPartition(numbers);
                            break;
                        }    
                        else
                        {
                            ShowError("В массиве должно быть только 2 уникальных числа");
                            return;
                        }
                    case "Задача Дейкстры":
                        isUnic = CheckOnUnic(numbers, 3);
                        if (isUnic && Greaters(numbers, 3) && !isNegative(numbers))
                        {
                            numbers = Sorts.DutchFlagSort(numbers);
                            break;
                        }
                        else
                        {
                            ShowError("В массиве должно быть только 3 уникальных числа, от 0 до 2 включительно");
                            return;
                        }
                    case "Сортировочная шляпа":
                        isUnic = CheckOnUnic(numbers, 4);
                        if (isUnic && Greaters(numbers, 4) && !isNegative(numbers))
                        {
                            numbers = Sorts.HogwartsHat(numbers);
                            break;
                        }
                        else
                        {
                            ShowError("В массиве должно быть только 4 уникальных числа, от 0 до 3 включительно");
                            return;
                        }
                }
                PrintArray(numbers);
            }
            else
            {
                ShowError("Введите корректный масив чисел для сортировки. См. справку");
            }
        }

        public static bool isNegative(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "Массив не может быть null.");
            }

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    return true; // Найдено отрицательное число
                }
            }

            return false; // Отрицательных чисел нет
        }

        public static bool Greaters(int[] array, int digit)
        {
            if (array == null || array.Length == 0)
                return false;

            foreach (int num in array)
            {
                if (num >= digit)
                    return false;
            }

            return true;
        }
        private static bool CheckOnUnic(int[] array, int ammount)
        {
            if (array == null || array.Length < 2)
                return false;

            var uniqueNumbers = array.Distinct().ToArray();
            return uniqueNumbers.Length == ammount;
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
        static private void ShowError(string err)
        {
            ErrorMsg f3 = new ErrorMsg(err);
            f3.ShowDialog();
        }
    }
}
