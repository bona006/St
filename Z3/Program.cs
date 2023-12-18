int[] array = { 1, 2, 3, 4, 5 };
PrintArrayReversed(array, array.Length - 1);

static void PrintArrayReversed(int[] array, int index)
{
    if (index >= 0)
    {
        Console.WriteLine(array[index]);
        PrintArrayReversed(array, index - 1);
    }
}