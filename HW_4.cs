// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiation (int a, int b)
// {
//     int result = (int)Math.Pow(a,b);
//     return result;
// }

// int InputNumber (string textNumber)
// {
// Console.WriteLine("Введите чиcло " + textNumber + ":");
// int a = Convert.ToInt32(Console.ReadLine());
// return a;
// }

// int Num1 = InputNumber("A");
// int Num2 = InputNumber("B");
// int res = Exponentiation (Num1,Num2);
// System.Console.WriteLine("А в степени равняется: " + res);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int InputNumber()
// {
//     Console.WriteLine("Введите чиcло:");
//     int a = Convert.ToInt32(Console.ReadLine());
//     return a;
// }

// int SummDigitsOfNumber(int num)
// {
//     int sum = 0;
//     while (num != 0)
//     {
//         int i = num % 10;
//         sum += i;
//         num = num / 10;
//     }
//     return sum;
// }

// int number = InputNumber();
// System.Console.WriteLine("Сумма цифр введенного чила = " + SummDigitsOfNumber(number));







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void CreateArray(int[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         massiv[i] = new Random().Next(1, 99);
//         System.Console.Write($"{massiv[i]}" + ", ");
//     }
// }

// System.Console.WriteLine("Введите количество элементов массива:");
// int Count = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[Count];
// CreateArray(array);





// ДОП ЗАДАЧИ
// Задача Array32. Дан массив размера N. Найти номер его первого локального минимума.
//Ищем индекс первого локального минимума.

// void CreateArray(int[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i++)
//         massiv[i] = new Random().Next(-99, 99);

// }

// int FindFirstLocalMin(int[] massiv)
// {
//     int localmin = (int)Math.Pow(33, 8); // на случай если локальных минимумов не будет, вернется значение "33 в 8 степени". (при необходимости работать с ним далее)
//     int i = -1; //изначально задаем "-1" на случай если в массиве нет локальных минимумов
//     if (massiv.Length > 1) //проверка на счлучай, если массив будет состоять из одного значения
//     {
//         if (massiv[0] < massiv[1]) //проверка первого элемента массива
//         {
//             localmin = massiv[0];
//             System.Console.WriteLine("Индекс первого локального минимума: " + 0);
//             return localmin; // если первый элемент является локальным минимумом, то это ответ
//         }
//         // if (massiv.Length > 2) //проверка на счлучай, если массив будет состоять из одного значения

//         for (i = 1; i <= massiv.Length - 1; i++) //проверяем все элементы массива, кроме последнего
//         {
//             if (((massiv.Length > 2) && (i < massiv.Length - 1) && (massiv[i] < massiv[i + 1] && massiv[i] < massiv[i - 1])) //проверка с 1 по предпоследний эл-т
//             || ((massiv.Length == 2) && (massiv[1] < massiv[0]))  // на случай если массив будет состоять из 2 элементов
//             || (i == massiv.Length - 1 && massiv[massiv.Length - 1] < massiv[massiv.Length - 2])) // проверка последнего элемента
//             {
//                 localmin = massiv[i];
//                 System.Console.WriteLine("Индекс первого локального минимума: " + i);
//                 return localmin; //как только встерили первый локальный минимум возвращаем его методу
//             }
//         }
//     }
//     if (i == -1)
//     {
//         System.Console.WriteLine("Локальный минимум в массиве не найден");
//     }
//     return localmin;
// }

// System.Console.WriteLine("Введите количество элементов массива:");
// int Count = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[Count];
// CreateArray(array);
// System.Console.WriteLine(string.Join(",", array));
// int Localmin = FindFirstLocalMin(array);
// if (Localmin != (int)Math.Pow(33, 8))
//     System.Console.WriteLine("Значение первого локального минимума: " + Localmin);





// Задача Array34. Дан массив размера N. Найти максимальный из его локальных минимумов.
// Ищем максимальный из локальных минимумов по значению.

// void CreateArray(int[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i++)
//         massiv[i] = new Random().Next(-99, 99);

// }



// int FindFirstLocalMin(int[] massiv)
// {
//     int maxlocalmin = (int)Math.Pow(33, 8); // на случай если локальных минимумов не будет, вернется значение "33 в 8 степени". (при необходимости работать с ним далее);
//     bool check = false; // для проверки, в случае если единственный локальный минимум - последний элемент
//     for (int i = 0; i < massiv.Length - 1; i++) // задаем первый найденый локальный минимум как максимальный
//     {
//         if ((i == 0 && massiv[i] < massiv[i + 1]) || (i > 0 && (massiv[i] < massiv[i + 1] && massiv[i] < massiv[i - 1])))
//         {
//             maxlocalmin = massiv[i];
//             check = true;
//             break;
//         }
//     }
//     for (int i = 0; i < massiv.Length - 1; i++) //проверяем все элементы массива, кроме последнего
//     {
//         if ((i == 0 && massiv[i] < massiv[i + 1]) || (i > 0 && (massiv[i] < massiv[i + 1] && massiv[i] < massiv[i - 1])))
//         {
//             System.Console.WriteLine("локальный минимум: " + massiv[i]);
//             if (massiv[i] > maxlocalmin) //проверяем все найденные локальные минимумы с 1 элемента до предпоследнего
//             {
//                 maxlocalmin = massiv[i];
//             }
//         }
//     }
//     if (massiv.Length > 1) //проверка на счлучай, если массив будет состоять из одного значения
//     {
//         if (massiv[massiv.Length - 1] < massiv[massiv.Length - 2]) //проверяем последний элемент массива
//         {
//             System.Console.WriteLine("локальный минимум: " + massiv[massiv.Length - 1]);
//             if (check == true && massiv[massiv.Length - 1] > maxlocalmin) //проверка на случай если до этого не было локальных минимумов
//             {
//                 maxlocalmin = massiv[massiv.Length - 1];
//             }
//             else
//             {
//                 maxlocalmin = massiv[massiv.Length - 1];
//             }
//         }
//     }
//     if (maxlocalmin == (int)Math.Pow(33, 8))
//     {
//         System.Console.WriteLine("Локальный минимум в массиве не найден");
//     }
//     return maxlocalmin;
// }

// System.Console.WriteLine("Введите количество элементов массива:");
// int Count = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[Count];
// CreateArray(array);
// System.Console.WriteLine(string.Join(",", array));
// int MaxLocalmin = FindFirstLocalMin(array);
// if (MaxLocalmin != (int)Math.Pow(33, 8))
//     System.Console.WriteLine("Максимальный локальный минимум равен: " + MaxLocalmin);





// Задача Array37. Дан массив размера N. Найти количество участков, на которых его элементы монотонно возрастают.

// void CreateArray(int[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i++)
//         massiv[i] = new Random().Next(-99, 99);

// }

// int AreasOfIncrease(int[] massiv)
// {
//     int count = 0;
//     bool check = false;
//     if (massiv.Length > 1) // на случай если массив состоит из 1 элемента
//     {
//         for (int i = 0; i < massiv.Length - 1; i++)
//         {
//             if (massiv[i] < massiv[i + 1] && check == false)
//             {
//                 count += 1;
//                 check = true;
//             }
//             else
//             {
//                 if (massiv[i] < massiv[i + 1])
//                 {
//                     check = true;
//                 }
//                 else
//                 {
//                     check = false;
//                 }
//             }
//         }
//     }
//     else
//     {
//         count = 0;
//     }
//     return count;
// }

// Console.WriteLine("Введите количество элементов массива:");
// int Count = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[Count];
// CreateArray(array);
// System.Console.WriteLine(string.Join(",", array));
// System.Console.WriteLine(AreasOfIncrease(array));



// Задача Array41. Дан массив размера N. Найти два соседних элемента, сумма которых максимальна, 
// и вывести эти элементы в порядке возрастания их индексов.

// void CreateArray(int[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i++)
//         massiv[i] = new Random().Next(0, 22);

// }

// int FindIndexOfMaxSumm(int[] massiv)
// {
//     int i = 0;
//     int index = 0;
//     int summ = massiv[i] + massiv[i + 1];
//     for (i = 1; i < massiv.Length - 1; i++)
//     {
//         if (massiv[i] + massiv[i + 1] > summ)
//         {
//             index = i;
//         }
//     }
//     return index;
// }

// void PrintElements(int ind, int[] arr)
// {
//     System.Console.WriteLine("Ответ: " + arr[ind] + "," + arr[ind + 1]);
// }

// Console.WriteLine("Введите количество элементов массива:");
// int Count = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[Count];
// CreateArray(array);
// System.Console.WriteLine(string.Join(",", array));
// PrintElements(FindIndexOfMaxSumm(array), array);



// Задача Array45. Дан массив размера N. Найти номера двух ближайших элементов из этого массива (тоесть элементов с наименьшим модулем разности) и вывести эти номера в порядке возрастания.
