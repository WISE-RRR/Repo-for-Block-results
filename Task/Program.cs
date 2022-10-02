void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число, соответствующее количеству элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1}-й элемент: ");
    string? element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element!;
}

string[] arrayThreeSymbol = new string[size];
int symbol = 3;
int position = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= symbol)
    {
        arrayThreeSymbol[position] = arrayStrings[j];
        position++;
    }
}

Console.WriteLine();
ShowArray(arrayThreeSymbol);

