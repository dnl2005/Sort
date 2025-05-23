﻿
using System;
using System.CodeDom.Compiler;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    /// <summary>
    /// Класс, содержащий различные алгоритмы сортировки массивов
    /// </summary>
    public class Sorts
    {

        /// <summary>
        /// Меняет местами два элемента массива
        /// </summary>
        /// <param name="e1">Первый элемент</param>
        /// <param name="e2">Второй элемент</param>
        public static void Swap(ref int e1, ref int e2)
        {
            (e2, e1) = (e1, e2);
        }

        /// <summary>
        /// Сортировка пузырьком (Bubble Sort)
        /// </summary>
        /// <param name="nums">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        /// <remarks>
        /// Алгоритм последовательно сравнивает пары соседних элементов и меняет их местами,
        /// если они находятся в неправильном порядке. Процесс повторяется, пока массив не будет отсортирован.
        /// Сложность: O(n^2) в худшем случае.
        /// </remarks>
        public static int[] BubbleSort(int[] nums)
        {
            var len = nums.Count();
            for (var i = 1; i < len; i++)
                for (var j = 0; j < len - i; j++)
                    if (nums[j] > nums[j + 1])
                        Swap(ref nums[j], ref nums[j + 1]);

            return nums;
        }

        /// <summary>
        /// функция генерации случайных чисел
        /// </summary>
        /// <param name="length">длинна массива</param>
        /// <param name="task">спецификатор задачи, 0 - любые числа, 1 - (0,1), 2 - (0,1,2), 3 - (0,1,2,3)</param>
        /// <returns>возвращает целочисленный массим случайных чисел</returns>
        public static int[] genRandInt(int length, int task = 0)
        {
            int[] nums = new int[length];
            Random randNum = new Random();
            switch (task)
            {
                case 0://Любые числа
                    for (int i = 0; i < length; i++)
                    {
                        nums[i] = randNum.Next(0, 101);
                    }
                    break;
                case 1://0 и 1
                    for (int i = 0; i < length; i++)
                    {
                        nums[i] = randNum.Next(0, 2);
                    }
                    break;
                case 2://0 1 и 2
                    for (int i = 0; i < length; i++)
                    {
                        nums[i] = randNum.Next(0, 3);
                    }
                    break;
                case 3://0 1 2 и 3
                    for (int i = 0; i < length; i++)
                    {
                        nums[i] = randNum.Next(0, 4);
                    }
                    break;
            }
            return nums;
        }
        /// <summary>
        /// Сортировка вставками (Insertion Sort)
        /// </summary>
        /// <param name="nums">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        /// <remarks>
        /// Алгоритм строит отсортированную последовательность, по одному элементу за раз,
        /// вставляя каждый новый элемент в правильную позицию среди уже отсортированных элементов.
        /// Сложность: O(n^2) в худшем случае, O(n) в лучшем (для почти отсортированных массивов).
        /// </remarks>
        static public int[] InsertionSort(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                var key = nums[i];
                var j = i;
                while (j > 0 && nums[j - 1] > key)
                {
                    nums[j] = nums[j - 1];
                    j--;
                }
                nums[j] = key;
            }
            return nums;
        }

        /// <summary>
        /// Сортировка слиянием (Merge Sort)
        /// </summary>
        /// <param name="nums">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        /// <remarks>
        /// Алгоритм использует стратегию "разделяй и властвуй":
        /// массив разделяется на две части, каждая сортируется рекурсивно,
        /// затем отсортированные части сливаются в один массив.
        /// Сложность: O(n log n) в любом случае.
        /// </remarks>
        public static int[] MergeSort(int[] nums)
        {
            if (nums.Length <= 1)
                return nums;

            int mid = nums.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[nums.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = nums[i];

            for (int i = mid; i < nums.Length; i++)
                right[i - mid] = nums[i];

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        /// <summary>
        /// Вспомогательный метод для слияния двух отсортированных списков
        /// </summary>
        /// <param name="left">Левый отсортированный список</param>
        /// <param name="right">Правый отсортированный список</param>
        /// <returns>Объединенный отсортированный массив</returns>
        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }

        /// <summary>
        /// Быстрая сортировка (Quick Sort)
        /// </summary>
        /// <param name="nums">Массив для сортировки</param>
        /// <param name="left">Левая граница сортировки</param>
        /// <param name="right">Правая граница сортировки</param>
        /// <returns>Отсортированный массив</returns>
        /// <remarks>
        /// Алгоритм использует стратегию "разделяй и властвуй":
        /// выбирается опорный элемент, массив разделяется на две части -
        /// элементы меньше опорного и элементы больше опорного,
        /// затем каждая часть сортируется рекурсивно.
        /// Сложность: O(n log n) в среднем, O(n^2) в худшем случае.
        /// </remarks>
        public static int[] QuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = Partition(nums, left, right);
                QuickSort(nums, left, pivotIndex - 1);
                QuickSort(nums, pivotIndex + 1, right);
            }
            return nums;
        }

        /// <summary>
        /// Вспомогательный метод для быстрой сортировки - разделение массива
        /// </summary>
        /// <param name="nums">Массив для разделения</param>
        /// <param name="left">Левая граница</param>
        /// <param name="right">Правая граница</param>
        /// <returns>Индекс опорного элемента</returns>
        private static int Partition(int[] nums, int left, int right)
        {
            var pivot = nums[right];
            var i = left;
            for (var j = left; j < right; j++)
            {
                if (nums[j] < pivot)
                {
                    Swap(ref nums[i], ref nums[j]);
                    i++;
                }
            }
            Swap(ref nums[i], ref nums[right]);
            return i;
        }

        /// <summary>
        /// Блочная сортировка (Bucket Sort)
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        /// <remarks>
        /// Алгоритм распределяет элементы в несколько "ведер" (блоков),
        /// затем сортирует каждое ведро отдельно (обычно insertion sort'ом),
        /// и наконец объединяет все ведра в один массив.
        /// Эффективен, когда входные данные равномерно распределены.
        /// Сложность: O(n + k) в лучшем случае, O(n^2) в худшем.
        /// </remarks>
        public static int[] BucketSort(int[] array)
        {
            // Находим минимальное и максимальное значения
            int minValue = array[0];
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue) minValue = array[i];
                if (array[i] > maxValue) maxValue = array[i];
            }

            // Создаем черпаки (ведра)
            int bucketCount = array.Length;
            List<int>[] buckets = new List<int>[bucketCount];
            for (int i = 0; i < bucketCount; i++)
                buckets[i] = new List<int>();

            // Распределяем элементы по ведрам
            for (int i = 0; i < array.Length; i++)
            {
                int bucketIndex = (int)((long)(array[i] - minValue) * (bucketCount - 1) / (maxValue - minValue));
                buckets[bucketIndex].Add(array[i]);
            }

            // Собираем результат
            var result = new int[array.Length];
            int index = 0;
            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i].Sort();
                foreach (var item in buckets[i])
                {
                    result[index++] = item;
                }
            }
            return result;
        }

        /// <summary>
        /// Двухстороннее разделение массива относительно опорного элемента
        /// </summary>
        /// <param name="array">Массив для разделения</param>
        /// <param name="pivot">Опорный элемент</param>
        /// <remarks>
        /// Через HashSet находит два уникальных элемента и сортирует их
        /// Считает количество младших значений в массиве
        /// Сначала заполняет все младшие значения, затем оставшиеся позиции
        /// Сложность: O(n).
        /// </remarks>
        public static int[] TwoWayPartition(int[] arr)
        {
            var unique = new HashSet<int>(arr).OrderBy(x => x).ToList();
            int minVal = unique[0];
            int maxVal = unique[1];

            int count = arr.Count(x => x == minVal);
            Array.Fill(arr, minVal, 0, count);
            Array.Fill(arr, maxVal, count, arr.Length - count);

            return arr;
        }
        /// <summary>
        /// Сортировка Задачи Дейкстры
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <remarks>
        /// Алгоритм сортирует массив из трех возможных значений (0, 1, 2)
        /// за один проход по массиву с постоянной дополнительной памятью.
        /// Сложность: O(n).
        /// </remarks>
        public static int[] DutchFlagSort(int[] array)
        {
            int low = 0;    // Указатель для 0 (конец первой группы)
            int mid = 0;     // Указатель для 1 (текущий элемент)
            int high = array.Length - 1; // Указатель для 2 (начало третьей группы)

            // Предполагаем, что средний элемент (pivot) = 1
            while (mid <= high)
            {
                switch (array[mid])
                {
                    case 0: // Белый
                        (array[low], array[mid]) = (array[mid], array[low]);
                        low++;
                        mid++;
                        break;
                    case 1: // Синий
                        mid++;
                        break;
                    case 2: // Красный
                        (array[mid], array[high]) = (array[high], array[mid]);
                        high--;
                        break;
                }
            }

            return array;
        }

        /// <summary>
        /// Сортировка "Шляпа Хогвартса" 
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <remarks>
        /// Алгоритм сортирует массив из четырех возможных значений (0, 1, 2, 3),
        /// представляющих факультеты Хогвартса, за один проход по массиву.
        /// Сложность: O(n).
        /// </remarks>
        public static int[] HogwartsHat(int[] array)
        {
            // Предполагаем, что дома Хогвартса представлены числами 0-3:
            // 0 - Гриффиндор, 1 - Слизерин, 2 - Когтевран, 3 - Пуффендуй

            int first = 0;    // Граница для 0 (Гриффиндор)
            int second = 0;   // Граница для 1 (Слизерин)
            int third = 0;    // Граница для 2 (Когтевран)
            int fourth = array.Length - 1; // Граница для 3 (Пуффендуй)

            while (third <= fourth)
            {
                switch (array[third])
                {
                    case 0: // Гриффиндор
                        (array[first], array[third]) = (array[third], array[first]);
                        if (first < second) (array[second], array[third]) = (array[third], array[second]);
                        first++;
                        second++;
                        third++;
                        break;
                    case 1: // Слизерин
                        (array[second], array[third]) = (array[third], array[second]);
                        second++;
                        third++;
                        break;
                    case 2: // Когтевран
                        third++;
                        break;
                    case 3: // Пуффендуй
                        (array[third], array[fourth]) = (array[fourth], array[third]);
                        fourth--;
                        break;
                }
            }
            return array;
        }
    }
}