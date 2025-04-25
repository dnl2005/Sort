using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private static SortResultsForm resultsForm;
        private string taskName;
        private string input;

        public TaskForm(string taskName, SortResultsForm resultsFormInstance)
        {
            InitializeComponent();
            resultsForm = resultsFormInstance;

            this.taskName = taskName;
            Title.Text = taskName;
            Title.AutoSize = true;
            Title.Anchor = AnchorStyles.None;
            Title.TextAlign = ContentAlignment.MiddleCenter;

            CenterTitle();
            this.Resize += (s, e) => CenterTitle();
        }

        /// <summary>
        /// метод центрации заголовка относительно формы
        /// </summary>
        private void CenterTitle()
        {
            Title.Left = (this.ClientSize.Width - Title.Width) / 2;
        }

        /// <summary>
        /// слушатель ввода в поле
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        /// <summary>
        /// обработчик нажатия на кнопку сортировки
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = StringToArray();

            if (numbers != null)
            {
                switch (taskName)
                {
                    case "Пузырьковая сортировка":
                        // сортировка и замер времени
                        (numbers, TimeSpan time) = PerformAndMeasure(Sorts.BubbleSort, numbers);

                        // вывод результата
                        SetResult(numbers, "Пузырьковая сортировка", "O(n^2)", time.Milliseconds, "O(1)");
                        break;

                    case "Сортировка вставкой":
                        // сортировка и замер времени
                        (numbers, time) = PerformAndMeasure(Sorts.InsertionSort, numbers);


                        SetResult(numbers, "Сортировка вставкой", "O(n^2)", time.Milliseconds, "O(1)");
                        break;

                    case "Сортировка слиянием":
                        // сортировка и замер времени
                        (numbers, time) = PerformAndMeasure(Sorts.MergeSort, numbers);


                        SetResult(numbers, "Сортировка слиянием", "O(n log n)", time.Milliseconds, "O(1)");
                        break;

                    case "Быстрая сортировка":
                        // сортировка и замер времени
                        (numbers, time) = PerformAndMeasure(nums =>
                        {
                            return Sorts.QuickSort(nums, 0, nums.Length - 1);
                        }, numbers);


                        SetResult(numbers, "Быстрая сортировка", "O(n lon n)", time.Milliseconds, "O(1)");
                        break;

                    case "Сортировка черпаками":
                        // сортировка и замер времени
                        (numbers, time) = PerformAndMeasure(Sorts.BucketSort, numbers);


                        SetResult(numbers, "Сортировка черпаками", "O(n)", time.Milliseconds, "O(1)");
                        break;

                    case "сортировка Хоара":
                        // проверка на уникальность
                        bool isUnic = CheckOnUnic(numbers, 2);
                        if (isUnic)
                        {
                            // сортировка и замер времени
                            (numbers, time) = PerformAndMeasure(Sorts.TwoWayPartition, numbers);


                            SetResult(numbers, "сортировка Хоара", "O(n)", time.Milliseconds, "O(1)");
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
                            // сортировка и замер времени
                            (numbers, time) = PerformAndMeasure(Sorts.DutchFlagSort, numbers);


                            SetResult(numbers, "Задача Дейкстры", "O(n)", time.Milliseconds, "O(1)");
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
                            // сортировка и замер времени
                            (numbers, time) = PerformAndMeasure(Sorts.HogwartsHat, numbers);


                            SetResult(numbers, "Сортировочная шляпа", "O(n)", time.Milliseconds, "O(1)");
                            break;
                        }
                        else
                        {
                            ShowError("В массиве должно быть только 4 уникальных числа, от 0 до 3 включительно");
                            return;
                        }
                }
                textBox2.Text = PrintArray(numbers);
            }
            else
            {
                ShowError("Введите корректный масив чисел для сортировки. См. справку");
            }
        }

        /// <summary>
        /// проверка на отрицальеное число
        /// </summary>
        /// <param name="numbers">массив чисел, целое число</param>
        /// <returns>true - есть отрицательное, false - нет отрицательного числа</returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// метод проверки на превышение значения числа
        /// </summary>
        /// <param name="array">массив, целое число</param>
        /// <param name="digit">число, относительно которого выполняется проверка, целое</param>
        /// <returns></returns>
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

        /// <summary>
        /// проверка на уникальность числа
        /// </summary>
        /// <param name="array">массив, целое число</param>
        /// <param name="ammount">количество уникальных чисел</param>
        /// <returns></returns>
        private static bool CheckOnUnic(int[] array, int ammount)
        {
            if (array == null || array.Length < 2)
                return false;

            var uniqueNumbers = array.Distinct().ToArray();
            return uniqueNumbers.Length == ammount;
        }

        /// <summary>
        /// метод вывода массива в поле вывода
        /// </summary>
        /// <param name="list">массив чисел</param>
        /// <returns>строку-массив</returns>
        private string PrintArray(int[] list)
        {
            string output = "";

            for (int i = 0; i < list.Length; i++)
            {
                output += list[i];

                if (i != list.Length - 1)
                    output += ", ";
            }

            return output;
        }

        /// <summary>
        /// метод добавления результата в таблицу
        /// </summary>
        /// <param name="numbers">массив чисел</param>
        /// <param name="method">метод</param>
        /// <param name="complexity">сложность</param>
        /// <param name="time">время</param>
        /// <param name="memComplexity">затраты памяти</param>
        private static void SetResult(int[] numbers, string method, string complexity, float time, string memComplexity)
        {
            SortResult result = new SortResult
            {
                Method = method,
                Complexity = complexity,
                ElementCount = numbers.Length,
                TimeInSeconds = time,
                MemoryComplexity = memComplexity
            };

            resultsForm.AddSortResult(result);
        }


        /// <summary>
        /// перевод строки в массив
        /// </summary>
        /// <returns>массив</returns>
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


        /// <summary>
        /// метод вывода формы с сообщением об ошибке
        /// </summary>
        /// <param name="err">текст ошибки</param>
        static private void ShowError(string err)
        {
            ErrorMsg f3 = new ErrorMsg(err);
            f3.ShowDialog();
        }

        /// <summary>
        /// обработчик кнопки генерации массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(arrLength.Text, out int len))
            {
                ShowError("Введено некорректное значение длины");
                return;
            }

            switch (taskName)
            {
                case "сортировка Хоара":
                    textBox1.Text = PrintArray(Sorts.genRandInt(len, 1));
                    break;
                case "Задача Дейкстры":
                    textBox1.Text = PrintArray(Sorts.genRandInt(len, 2));
                    break;
                case "Сортировочная шляпа":
                    textBox1.Text = PrintArray(Sorts.genRandInt(len, 3));
                    break;
                default:
                    textBox1.Text = PrintArray(Sorts.genRandInt(len));
                    break;
            }
            
        }

        /// <summary>
        /// Замеряет время выполнения функции, принимающей массив int[]
        /// </summary>
        /// <param name="function">Функция для выполнения</param>
        /// <param name="inputArray">Входной массив</param>
        /// <returns>Кортеж (результат, время выполнения)</returns>
        public static (int[] Result, TimeSpan Elapsed) PerformAndMeasure(Func<int[], int[]> function, int[] inputArray)
        {
            // пример вызов функции: (numbers, TimeSpan time) = PerformAndMeasure(Sorts.BubbleSort,numbers);
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] result = function(inputArray);
            stopwatch.Stop();
            //пример вывода замера времени:
            //MessageBox.Show($"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds} мс",
            //"Результат замера",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information);
            return (result, stopwatch.Elapsed);
        }
    }
}
