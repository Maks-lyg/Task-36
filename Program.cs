Console.Clear();
Console.Write("Введите размер");
int size = int.Parse(Console.RaedLine());
int s = Chetnie(sum);
Console.Write($"Ответ - {s}");

int[] Array(int size)
{
    int[] array = new int [size];
    for (int i = 0; i< size; i++)
    {
        array[i] = new Random().Next(10,100);
    }
    return array;
}

int Chetnie(int evNumber)
{
    int sum = 0;
    for (int i = 0; i < size; i+=2)
    {
        sum += array[i]; // изначально было -> sum += i;
    }
    return sum;
}