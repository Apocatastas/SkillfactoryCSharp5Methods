using System;

class MainClass
{
    const int arrLen = 3;

    static int[] CopyArray(int[] arr)
    {
        int[] arrCopy = new int[arrLen];

        for (int i = 0; i < arrLen; i++)
        {
            arrCopy[i] = arr[i];
        }

        return arrCopy;
    }


    static void SortArray(in int[] arr, out int[] sortedAsc, out int[] sortedDesc)
    {
        sortedAsc = SortArrayAsc(arr);

        sortedDesc = SortArrayDesc(CopyArray(arr));

    }


    static int[] SortArrayDesc(int[] arr)
    {
        int buf = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    buf = arr[j];
                    arr[j] = arr[i];
                    arr[i] = buf;
                }
            }
        }

        return arr;
    }

    static int[] SortArrayAsc(int[] arr)
    {
        int buf = 0;
       for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    buf = arr[i];
                    arr[i] = arr[j];
                   arr[j] = buf;
                }
            }
       }

        return arr;
    }
    

    static int[] GetArrayFromConsole(int len = arrLen)
    {
        var result = new int[len];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    public static void ShowArray(in int[] arr, out int[] sortedAsc, out int[] sortedDesc)
    {
        SortArray(in arr, out sortedAsc, out sortedDesc);


            Console.WriteLine("Ascending: ");
            foreach (var item in sortedAsc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nDescending: ");
            foreach (var item in sortedDesc)
            {
                Console.Write(item + " ");
            }

    }

    public static void Main(string[] args)
    {
        var sortedAsc = new int[arrLen];
        var sortedDesc = new int[arrLen];
        int[] arrForSort = new int[arrLen];
        arrForSort = GetArrayFromConsole();
        ShowArray(in arrForSort, out sortedAsc, out sortedDesc);
        Console.ReadKey();

    }
}