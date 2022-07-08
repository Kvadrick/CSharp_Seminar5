int n;
Console.WriteLine("Напишите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum = sum + array[i];
        i++;
    }
}
Console.WriteLine(sum);

