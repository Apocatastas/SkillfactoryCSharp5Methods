using System;

class MainClass
{
    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Основание: ");
        var number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Степень: ");
        byte pow = Convert.ToByte(Console.ReadLine());

            number = PowerUp(number, pow);



        Console.WriteLine(number);
        
        Console.ReadKey();
    }

   

    }