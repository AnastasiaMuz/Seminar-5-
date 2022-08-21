// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int [] array = new int[5];

Random rand = new Random();
Console.WriteLine ("Введите искомое число:");
int find = Convert.ToInt32(Console.ReadLine());
bool res = false;

for (int i = 0; i< array.Length; i++)
{
    array[i] = rand.Next(-100,101);
    if(array[i] == find)
    {
        res = true;
    }
}
Console.WriteLine(string.Join(", ", array));
if (res == true)
{
    Console.WriteLine ("да");
}
else 
{
    Console.WriteLine ("нет");
}