namespace TourOfCsharp;

public class Program
{
    static void Main()
    {
        #region Hello world, introducing strings

        Console.WriteLine("Hello world, introducing strings");
        Console.WriteLine("=============\r\n");

        Console.WriteLine("Hello, world!");

        string firstFriend = "Maria";
        string secondFriend = "Scott";

        Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend);
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

        Console.WriteLine("\r\n");

        #endregion

        #region The basics of strings

        Console.WriteLine("The basics of strings");
        Console.WriteLine("=====================\r\n");

        string greeting = "      Greetings!  ";

        Console.WriteLine(greeting.Trim());

        string friends = $"My friends are {firstFriend} and {secondFriend}";

        Console.WriteLine("\r\n");

        #endregion

        #region Searching strings

        Console.WriteLine("Searching strings");
        Console.WriteLine("=================\r\n");

        Console.WriteLine(friends.Replace("Maria", "John"));
        Console.WriteLine(friends.Contains("Scott"));
        Console.WriteLine(friends.Contains("Rebecca"));
        Console.WriteLine(friends.ToUpper());
        Console.WriteLine(friends.Length);
        Console.WriteLine(friends.StartsWith("Scott"));
        Console.WriteLine(friends.StartsWith("My"));

        Console.WriteLine("\r\n");

        #endregion

        #region Numbers, integers, and maths

        Console.WriteLine("Numbers, integers, and maths");
        Console.WriteLine("============================\r\n");

        int a = (int)42.1;
        int b = (int)38.3;
        long c = checked(a + b);

        Console.WriteLine($"The sum of {a} and {b} is {c}");

        Console.WriteLine("\r\n");

        #endregion

        #region Numbers, precision, casting, doubles, and more

        Console.WriteLine("Numbers, precision, casting, doubles, and more");
        Console.WriteLine("==============================================\r\n");

        decimal d = 42.1M;
        decimal e = 38.3M;
        decimal f = checked(d + e);

        Console.WriteLine($"The sum of {d} and {e} is {f}");

        int g = 1;
        int h = 2;
        int i = checked(g + h);

        Console.WriteLine("\r\n");

        #endregion

        #region Branching, ifs, and conditional logic

        Console.WriteLine("Branching, ifs, and conditional logic");
        Console.WriteLine("=====================================\r\n");

        if (d + e > 10)
        {
            Console.WriteLine($"The sum of {d} and {e} is greater than 10");
        }
        else
        {
            Console.WriteLine($"The sum of {d} and {e} is not greater than 10");
        }

        if (i > 10)
        {
            Console.WriteLine($"The sum of {g} and {h} is greater than 10");
        }
        else
        {
            Console.WriteLine($"The sum of {g} and {h} is not greater than 10");
        }

        if ((d + e > 10) && (i == 3))
        {
            Console.WriteLine($"The sum of {d} and {e} is greater than 10");
            Console.WriteLine($"And the sum of {g} and {h} is 3");
        }
        else
        {
            Console.WriteLine($"The sum of {g} and {h} is not greater than 10");
            Console.WriteLine($"And/or the sum of {g} and {h} is not 3");
        }

        if ((d + e > 10) || (i == 3))
        {
            Console.WriteLine($"Either the sum of {d} and {e} is greater than 10");
            Console.WriteLine($"Or the sum of {g} and {h} is 3");
        }
        else
        {
            Console.WriteLine($"The sum of {g} and {h} is not greater than 10");
            Console.WriteLine($"And the sum of {g} and {h} is not 3");
        }

        Console.WriteLine("\r\n");

        #endregion

        #region Branching and while loops

        Console.WriteLine("Branching and while loops");
        Console.WriteLine("=========================\r\n");

        int counter = 0;

        while (counter < 5)
        {
            Console.WriteLine($"Counter is {counter}");

            counter++;
        }

        counter = 0;

        do
        {
            Console.WriteLine($"Counter is {counter}");

            counter++;
        }
        while (counter < 10);

        Console.WriteLine("\r\n");

        #endregion

        #region For loops

        Console.WriteLine("For loops");
        Console.WriteLine("=========\r\n");

        for (int j = 0; j < 15; j++)
        {
            Console.WriteLine($"Counter is {j}");
        }

        for (int j = 0; j < 15; j++)
        {
            if (j == 3)
            {
                Console.WriteLine($"Counter is {j}");

                continue;
            }
        }

        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"Row {row}, Column {column}");
            }
        }

        Console.WriteLine("\r\n");

        #endregion

        #region List<T> and collections of data

        Console.WriteLine("List<T> and collections of data");
        Console.WriteLine("===============================\r\n");

        var names = new List<string> { "Philip", "Maria", "Scott" };

        foreach (var name in names)
        {
            Console.WriteLine($"Hello, {name.ToUpper()}!");
        }

        names.Add("John");
        names.Add("Sara");
        names.Add("Grace");
        names.Remove("Scott");

        foreach (var name in names)
        {
            Console.WriteLine($"Hello, {name.ToUpper()}!");
        }

        Console.WriteLine("\r\n");

        #endregion

        #region Arrays, lists, indexing, and foreach

        Console.WriteLine("Arrays, lists, indexing, and foreach");
        Console.WriteLine("====================================\r\n");

        Console.WriteLine($"My first friend is {names[0]}");
        Console.WriteLine($"My second friend is {names[1]}");
        Console.WriteLine($"My third friend is {names[2]}");
        Console.WriteLine($"My last friend is {names[^1]}");
        Console.WriteLine($"My second from last friend is {names[^2]}");
        Console.WriteLine($"My third from last friend is {names[^3]}");

        Console.WriteLine("My first two friends are:");

        foreach (var name in names[0..2])
        {
            Console.WriteLine(name);
        }

        var namesArr = new string[] { "Philip", "Maria", "Scott" };

        namesArr = [.. names, "John"];

        foreach (var name in namesArr)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        Console.WriteLine("\r\n");

        #endregion

        #region Sorting and searching lists

        Console.WriteLine("Sorting and searching lists");
        Console.WriteLine("===========================\r\n");

        names.Sort();

        foreach (var name in names)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        var numbers = new List<int> { 42, 7, 23, 99, 17, 56 };
        
        Console.WriteLine($"Number 42 is at index {numbers.IndexOf(42)}");

        numbers.Sort();

        foreach (var number in numbers)
        {
            Console.WriteLine($"Number {number}");
        }

        Console.WriteLine($"Number 42 is at index {numbers.IndexOf(42)}");

        Console.WriteLine("\r\n");

        #endregion
    }
}
