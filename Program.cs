namespace TourOfCsharp;

public class Program
{
    static void Main()
    {
        #region Strings

        // This line prints "Hello, World!" to the console.
        Console.WriteLine("Hello, World!");
        
        // Strings and interpolation.
        string firstFriend = "Maria";
        string secondFriend = "Scott";

        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

        // Concatenation.
        Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend);

        // String trimming.
        string greeting = "      Greetings!  ";

        Console.WriteLine(greeting.Trim());

        // String replacement.
        string friends = $"My friends are {firstFriend} and {secondFriend}";

        Console.WriteLine(friends.Replace("Maria", "John"));

        // String contains.
        Console.WriteLine(friends.Contains("Scott"));
        Console.WriteLine(friends.Contains("Rebecca"));

        // String to upper case.
        Console.WriteLine(friends.ToUpper());

        // String length.
        Console.WriteLine(friends.Length);

        // String starts with.
        Console.WriteLine(friends.StartsWith("Scott"));
        Console.WriteLine(friends.StartsWith("My"));

        #endregion

        #region Numbers

        // Casting to an integer.
        int a = (int)42.1;
        int b = (int)38.3;
        long c = checked(a + b);

        Console.WriteLine($"The sum of {a} and {b} is {c}");

        // Decimal numbers.
        decimal d = 42.1M;
        decimal e = 38.3M;
        decimal f = checked(d + e);

        Console.WriteLine($"The sum of {d} and {e} is {f}");

        #endregion
    }
}
