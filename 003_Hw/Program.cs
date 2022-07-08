int n;
Console.WriteLine("Введите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(10, 1000) / 100.0);
   
}
Console.WriteLine("[" + string.Join(", ", array) + "]");


double max = array[0], min = array[0], c = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max) {
        
    max = array[i];
    }
    if(min > array[i]){

        min = array[i];
    }
    c = max - min;
}

Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"Разность = {c}");

