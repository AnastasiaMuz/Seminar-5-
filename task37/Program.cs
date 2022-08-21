//  Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] array = new int[8];

Random rand = new Random();

for (int i = 0; i< array.Length; i++)
{
    array[i] = rand.Next(-9,10);
}
Console.WriteLine(string.Join(", ", array));

int[] array2 = new int [array.Length / 2 + array.Length % 2];
for (int i = 0; i< array.Length/2; i++)
{
    array2[i] = array [i] * (array [array.Length - 1 - i]);
}
if (array.Length % 2 != 0)
{
    array2[array2.Length - 1] = array[array.Length/2];
}
Console.WriteLine(string.Join(", ", array2));