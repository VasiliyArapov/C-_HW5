// Задача 1
// int[] array = GetArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"The amount of even numbers is {AmountOfEvenNum(array)}");

// Задача 2
// int[] array = GetArray(10, 1, 9);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"The summ of odd indices is {OddIndexSum(array)}");

// Задача 3
int[] array = GetArray(9, 1, 5);
Console.WriteLine($"[{String.Join(",", array)}]");
int[] newArray = PairMultipl(array);
Console.WriteLine($"[{String.Join(",", newArray)}]");

// --------------Methods---------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int AmountOfEvenNum(int[] arr)
{
    int res = 0;
    foreach (int el in arr)
    {
        if(el % 2 == 0)
            res++;
    }
    return res;
}

int OddIndexSum(int[] a)
{
    int res = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(i % 2 != 0)
        {
            res += a[i];
        }
    }
    return res;
}

int[] PairMultipl(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int newArrSize = arr.Length / 2;
        int[] newArr = new int[newArrSize];
        int i = 0;
        int k = arr.Length - 1;
        while (i < newArrSize)
        {
            newArr[i] = arr[i] * arr[k];
            i++;
            k--;
        }
        return newArr;
    }
    else
    {
        int newArrSize = (arr.Length / 2) + 1;
        int[] newArr = new int[newArrSize];
        int i = 0;
        int k = arr.Length - 1;
        while (i < (newArrSize - 1))
        {
            newArr[i] = arr[i] * arr[k];
            i++;
            k--;
        }
        newArr[newArrSize - 1] = arr[newArrSize - 1];
        return newArr;
    }
}