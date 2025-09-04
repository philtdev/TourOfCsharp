namespace TourOfCsharp;

public class Program
{
    static void Main()
    {
        #region Strings

        Console.WriteLine("Hello, World!");

        string firstFriend = "Maria";
        string secondFriend = "Scott";

        Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend);
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

        string greeting = "      Greetings!  ";

        Console.WriteLine(greeting.Trim());

        string friends = $"My friends are {firstFriend} and {secondFriend}";

        Console.WriteLine(friends.Replace("Maria", "John"));
        Console.WriteLine(friends.Contains("Scott"));
        Console.WriteLine(friends.Contains("Rebecca"));
        Console.WriteLine(friends.ToUpper());
        Console.WriteLine(friends.Length);
        Console.WriteLine(friends.StartsWith("Scott"));
        Console.WriteLine(friends.StartsWith("My"));

        #endregion

        #region Numbers

        int a = (int)42.1;
        int b = (int)38.3;
        long c = checked(a + b);

        Console.WriteLine($"The sum of {a} and {b} is {c}");

        decimal d = 42.1M;
        decimal e = 38.3M;
        decimal f = checked(d + e);

        Console.WriteLine($"The sum of {d} and {e} is {f}");

        int g = 1;
        int h = 2;
        int i = checked(g + h);

        #endregion

        #region Branching, ifs, and conditional logic

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

        #endregion

        #region Branching and while loops

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

        #endregion

        #region For loops

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

        #endregion

        #region List<T> and collections of data

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

        #endregion
    }
}
