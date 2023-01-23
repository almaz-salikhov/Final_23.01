int FindSizeForNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i != arr.Length; i++)
    {

        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
    Console.WriteLine();
}
void FillArrayWithStrings(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i != arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
}

string[] array1 = new string[] { "something", "Rus", "2726", "-2", "world", "333" };
string[] array2 = new string[FindSizeForNewArray(array1)];

FillArrayWithStrings(array1, array2);
ShowArray(array2);
