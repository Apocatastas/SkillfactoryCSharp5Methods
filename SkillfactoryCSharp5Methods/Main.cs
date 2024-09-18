using System;

class MainClass
{
    static void GetName(string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }

    static void ChangeAge(ref int age)
    {
        age = 15;

    }


    public static void Main(string[] args)
    {
        string name = "Алла";
        int age = 0;
        /* 
         Console.WriteLine(name);
         GetName(name);
         Console.WriteLine(name);
        */

        Console.WriteLine(age);
        ChangeAge(ref age);
        Console.WriteLine(age);

        Console.ReadKey();

    }
}