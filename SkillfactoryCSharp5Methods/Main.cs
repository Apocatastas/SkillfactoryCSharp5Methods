using System;



class MainClass
{
    public static void Main(string[] args)
    {

        (string Name, string[] Dishes) User;

        User.Dishes = new string[5];

        Console.Write("Введите имя: ");
        User.Name = Console.ReadLine();


        for (int i = 0; i<User.Dishes.Length; i++ )
        {
            Console.Write("\nВведите ваше любимое блюдо {0}: ", i+1);
            User.Dishes[i] = Console.ReadLine();
        }

        Console.ReadLine();
    }
}

