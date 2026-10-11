namespace week1;

class Program
{
    static void Main(string[] args)
    {
 Console.WriteLine("Welcome to the greeting program!");
Console.WriteLine("What is your name? ");
string name = Console.ReadLine();

Console.WriteLine("What is your age? ");
string age = Console.ReadLine();

int age_class = int.Parse(age);
age_class = age_class + 1;

Console.WriteLine($"Hello, {name}! It's great to meet you. Wait, will you turn {age_class} this next year? Wow, you've grown fast");

    }
}
