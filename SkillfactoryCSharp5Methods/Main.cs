using System;

class MainClass
{
    static int[] BubbleSort(int[] arr)
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

    static int[] GetArrayFromConsole(int len = 5)
    {
        var result = new int[len];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int[] arrForSort = new int[5];
        arrForSort = GetArrayFromConsole();
        BubbleSort(arrForSort);

        foreach (var item in arrForSort)
        {
            Console.Write(item + " ");
        }



        Console.ReadKey();

    }
}