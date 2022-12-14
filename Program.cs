/* Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

/* int [] array = new int [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);    
}
Console.WriteLine(String.Join(", ", array));


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве = " + count);
 */


/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

/* Random myRn = new Random();
int[] a = new int[15];
Console.WriteLine("Исходный массив:");
 for (int i = 0; i < a.Length; i++) 
{
a[i] = myRnd.Next(-99, 999);
Console.Write(a[i] + " ");
}
int sum = 0;
for (int i = 1; i < a.Length; i += 1)
{
   if(i%2 != 0)  sum += a[i];
}   
Console.WriteLine("Сумма =" + sum); */
    

/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76 */


double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");


