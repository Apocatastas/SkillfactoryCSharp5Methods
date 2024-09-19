using System;

class Program
{
    static string[] FillStringArray(int quantity)
    {
        string[] stringArray = new string[quantity];
        for (int i = 0; i < quantity; i++)
        {
            Console.Write("Введите значение: ");
            stringArray[i] = Convert.ToString(Console.ReadLine());
        }

        return stringArray;
    }

    static int GetIntChecked()
    {
        int num;

        Console.Write("Введите число: ");

        while (true)
        {
            var input = Console.ReadLine();

            if ((int.TryParse(input, out num))&&(num > 0))
            {
                return num;
            }    
   
            else 
            {
                Console.WriteLine("Ошибка! Число должно быть больше нуля");
                Console.Write("Введите другое число: ");
            }
        }

    }

    static void PrintCortage((string, string, int, bool, int, string[], int, string[]) cortage)
    {
        Console.WriteLine("Вот какие данные вы ввели");
        Console.WriteLine("Вас зовут {0}",cortage.Item1);
        Console.WriteLine("Ваша фамилия {0}", cortage.Item2);
        Console.WriteLine("Ваш возраст " + Convert.ToString(cortage.Item3));

        if (!cortage.Item4) { Console.WriteLine("Питомцев нет"); }
        else
            {
                Console.WriteLine("У вас {0} питомцев. Вот их список: ", cortage.Item5);
                PrintNameList(cortage.Item6);

        }
        Console.WriteLine("У вас {0} любимых цветов. Вот их список: ",cortage.Item7);
        PrintNameList(cortage.Item8);
    }

    static void PrintNameList(string[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static bool GetBoolChecked()
    {
        string answer = Console.ReadLine();

        if (answer == "Да") return true; else return false;
          
    }



    static void Main(string[] args)
    {   /* name  surname age  isHasPet  petQuantity petNames  colorQuantity  Colors */
        (string, string, int, bool, int, string[], int, string[]) person;

        Console.WriteLine("Привет! Как ваше имя?");
        person.Item1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Ваша фамилия?");
        person.Item2 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Ваш возраст?");
        person.Item3 = GetIntChecked();




        Console.WriteLine("У вас есть питомцы? Да/Нет");
        person.Item4 = GetBoolChecked();

        if (person.Item4)
        {
            Console.WriteLine("Сколько у вас питомцев?");
            person.Item5 = GetIntChecked();
            person.Item6 = FillStringArray(person.Item5);
        }
        else
        {
            person.Item5 = 0;
            person.Item6 = new string[5];
        }


        Console.WriteLine("Сколько любимых цветов будем вводить?");
        person.Item7 = GetIntChecked();
        person.Item8 = FillStringArray(person.Item7);


        PrintCortage(person);

        Console.ReadKey();
    }

   

    }
