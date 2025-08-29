namespace TourOfCsharp;

public class Program
{
    static void Main()
    {
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
    }
}
