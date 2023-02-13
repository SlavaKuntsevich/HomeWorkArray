namespace HomeWorkArray
{
    internal class Program
    {
        static void Main(string[] args)
        {    // CYCLE$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            // Задача #1__________________________________________________________________
            //for (int operandOne = 0; operandOne <= 99; operandOne++)
            //{ if (operandOne % 2 != 0)
            //    Console.WriteLine(operandOne);
            //}
            // Задача #2__________________________________________________________________
            //  for (int operandOne = 5; operandOne > 0; operandOne--)
            //{
            //    Console.WriteLine(operandOne);
            //}
            // Задача #2 ver.2__________________________________________________________________
            //int operandOne = 5;
            //do
            //{
            //    Console.WriteLine(operandOne);
            //    operandOne--;
            //}while(operandOne > 0);
            // Задача #3__________________________________________________________________
            //Console.WriteLine("Введите любое целочисленное положительное число:");
            //uint operandOne = Convert.ToUInt32(Console.ReadLine());
            //uint operandTwo = 0;
            //for (uint i = 0 ; i <= operandOne ; i++)
            //{
            //    operandTwo = operandTwo + i; 
            //    Console.WriteLine(operandTwo);
            //}
            // Задача #4__________________________________________________________________
            //int operandOne = 0;
            //int operandTwo = 7;
            //while (operandOne <=98) {
            //    Console.WriteLine(operandOne);
            //    operandOne = operandOne + 7;
            //}
            // Задача #5__________________________________________________________________
            //int operandOne = 0;
            //do
            //{
            //    Console.WriteLine(operandOne);
            //    operandOne = operandOne - 5;
            //} while (operandOne != -55);
            //Задача #5 ver.2            
            //for (int operandOne = 0; operandOne <= -50; operandOne--)
            //{

            //    Console.WriteLine(operandOne);
            //    operandOne = operandOne - 5;

            //}

            //Задача #6__________________________________________________________________
            //Console.WriteLine("Введите число от 10 до 20:");
            //for (int b = 0; b <= 20; b++)
            //{
            //    b = int.Parse(Console.ReadLine());
            //    if (b < 10 || b >= 21) { break; }
            //    Console.WriteLine(Math.Sqrt(b));
            //}
            // ARRAY $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            //
            // TASK 0____________________________________
            //string[] stringsArray = new string [6];
            //Task 0
            //int[] nums1 = new int[6] { 13, 54, 24, 97, 86, 79 };
            //Console.WriteLine("Введите число");
            //int b = int.Parse(Console.ReadLine());
            //if (Array.IndexOf(nums1, b) != -1)
            //{
            //    Console.WriteLine("Число входит в массив");
            //}
            //else
            //{
            //    Console.WriteLine("Число не входит в массив");
            //}
            //bool a = false;
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    if (b == nums1[i])
            //    {
            //        a = true; break;
            //    }
            //ibibinkj
            //}
            //Console.WriteLine(a);
            // TASK 1____________________________________________________________________________
            //int[] arrayOne = { 2, 3, 8, 24, 37, 43 };
            //Console.WriteLine("Введите число,которое хотите удалить из массива:");
            //int operandOne = Convert.ToInt32(Console.ReadLine());
            //int arrayNew = 0;
            //bool boolOne = false;
            //Console.WriteLine("\nСтарый массив:");
            //for (int i = 0; i < arrayOne.Length; i++)
            //{
            //    Console.WriteLine(arrayOne[i]);
            //}
            //foreach (int item in arrayOne)

            //{
            //    if (operandOne == arrayOne[arrayNew])
            //    {
            //        boolOne = true;
            //    }
            //    if (item != operandOne)
            //    {
            //        arrayNew++;
            //    }
            //}
            //Console.WriteLine(boolOne ? "\nЧисло входит в массив" : "\nЧисло не входит в массив");
            //int[] arrayThree = new int[arrayNew];
            //int numbToDelete = 0;
            //for (int i = 0; i < arrayOne.Length; i++)
            //{
            //    if (arrayOne[i] != operandOne)
            //    {
            //        if (numbToDelete != arrayThree.Length)
            //        {
            //            arrayThree[numbToDelete] = arrayOne[i];
            //            numbToDelete++;
            //        }
            //    }
            //}
            //Console.WriteLine("\nИзмененный массив:");
            //for (int i = 0; i < arrayThree.Length; i++)
            //{
            //    Console.WriteLine(arrayThree[i]);
            //}
            //TASK 2________________________________________________________________________________
            //int numMin, numMax, valueMax = 0, valueMin = 0;
            //double summary = 0;
            //Console.Write("Введите количество элементов в массиве:");
            //int nums = Convert.ToInt32(Console.ReadLine());
            //int[] arrayOne = new int[nums];
            //numMax = arrayOne[valueMax];
            //numMin = arrayOne[valueMin];
            //Random random = new Random();
            //for (int x = 0; x < arrayOne.Length; x++)
            //{
            //    arrayOne[x] = random.Next(1, 78910);
            //    summary = summary + arrayOne[x];
            //    numMax = arrayOne[valueMax];
            //    numMin = arrayOne[valueMin];
            //    Console.WriteLine(arrayOne[x]);

            //    if (arrayOne[x] > numMax)
            //    {

            //        numMax = arrayOne[x];

            //        valueMax = x;
            //    }
            //    if (arrayOne[x] < numMin)
            //    {
            //        numMin = arrayOne[x];
            //        valueMin = x;
            //    }
            //}
            //Console.WriteLine($"Максимальное значение массива:{numMax}");
            //Console.WriteLine($"Минимальное значение массива:{numMin}");
            //Console.WriteLine($"Среднее арифметическое значение массива: {summary / nums}");

            // TASK 3_____________________________________________________________________________
            //int summaryOne = 0, summaryTwo = 0;
            //double midValueOne, midValueTwo;
            //int[] arrayOne = new int[5] { 23, 24, 117, 2017, 47 };
            //int[] arrayTwo = new int[5] { 1, 16, 78, 65, 68 };
            //Console.WriteLine("Первый массив");
            //for (int x = 0; x < arrayOne.Length; x++)
            //{
            //    summaryOne += arrayOne[x];
            //    Console.WriteLine(arrayOne[x] + " ");
            //}
            //Console.WriteLine($"\nВторой массив");
            //for (int y = 0; y < arrayTwo.Length; y++)
            //{
            //    summaryTwo = summaryTwo + arrayTwo[y];
            //    Console.WriteLine($"{arrayTwo[y]}");
            //}
            //midValueOne = summaryOne / 5;
            //midValueTwo = summaryTwo / 5;
            //Console.WriteLine($"\nСреднее арифметическое первого массива: " + midValueOne);
            //Console.WriteLine("Среднее арифметическое второго массива: " + midValueTwo);
            //if (midValueOne > midValueTwo)
            //{
            //    Console.WriteLine("Среднее арифметическое первого массива > второго");
            //}
            //if (midValueOne < midValueTwo)
            //{
            //    Console.WriteLine("Среднее арифметическое второго массива > больше первого");
            //}
            //if (midValueOne == midValueTwo)
            //{
            //    Console.WriteLine("Среднее арифметическое массивов ");
            //}
            //Дополнительные задания$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            //TASK 1
            //int numOne = 0, numTwo = 1, fibonacciLenght = 10;
            //Console.WriteLine("Первые 11 членов Фибоначчи: ");
            //Console.WriteLine(numOne + " ");
            //for (int i = 0;i < fibonacciLenght;i++)
            //{
            //    numOne = numTwo + numOne;
            //    numTwo = numOne - numTwo;
            //    Console.WriteLine(numOne);
            //}
            //TASK 2
            //Console.WriteLine("Введите сумму вклада: ");
            //float summary = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите срок вклада в месяцах: ");
            //int period = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= period; i++)
            //{
            //    summary += summary * 0.12f;
            //}
            //Console.WriteLine($"После {period} месяцев сумма вклада составит {summary}");
            //TASK 4
            //bool trueFalse = true;
            //while (trueFalse)
            //{
            //    Random rand = new Random();
            //    Console.WriteLine("Введите размер массива: ");
            //    int size = int.Parse(Console.ReadLine());
            //    int[] arrayOne = new int[size];
            //    int newArrayLength = 0;
            //    if (size > 5 && size <= 10)
            //    {
            //        trueFalse = false;
            //        for (int i = 0; i < arrayOne.Length; i++)
            //        {
            //            arrayOne[i] = rand.Next();
            //            Console.WriteLine(arrayOne[i]);
            //            if (arrayOne[i] % 2 == 0)
            //            {
            //                newArrayLength++;
            //            }
            //        }
            //        Console.WriteLine("\nМассив с четными числами ");
            //        int[] arrayThree = new int[newArrayLength];
            //        int numbForDelete = 0;
            //        for (int i = 0; i < arrayOne.Length; i++)
            //        {
            //            if (arrayOne[i] % 2 == 0)
            //            {
            //                if (numbForDelete != arrayThree.Length)
            //                {
            //                    arrayThree[numbForDelete] = arrayOne[i];
            //                    numbForDelete++;
            //                }
            //            }
            //        }
            //        for (int i = 0; i < arrayThree.Length; i++)
            //        {
            //            Console.WriteLine(arrayThree[i]);
            //        }


            //    }
            //    else
            //    {
            //        Console.WriteLine("Вы ввели неподходящее число");
            //    }
            //}
            //TASK 5_____________________________________________________________
            //int[] arrayOne = { 1,3,7,14,39,339};
            //for (int i = 0; i < arrayOne.Length; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        arrayOne[i] = 0;                   
            //    }
            //    Console.Write($"\t{arrayOne[i]}");
            //}
            //TASK 6
            //string[] names = { "2Pac", "Kendrick", "Travis", "Michael" };
            //Console.WriteLine("Текущий массив имен");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine("Отсортированный массив");
            //Array.Sort(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
        }

    }
}

    