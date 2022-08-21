// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int [] array = new int [4];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine ("Введите элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    array[i] = 0 - array[i]; // либо * -1
}
Console.WriteLine();
Console.Write (string.Join(", ", array));