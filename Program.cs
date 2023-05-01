Console.Write("Введите элементы массива через пробел: ");
string[] input = Console.ReadLine().Split(' ');
string[] output = new string[input.Length];

NewArrayWith3(input, output);
PrintArray(output);

void NewArrayWith3(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
