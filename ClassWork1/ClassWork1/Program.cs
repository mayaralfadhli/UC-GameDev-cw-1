// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
        string heroName = "mayar";
        Console.WriteLine("hero Name" + heroName);
        int heroHeight = 167;
        Console.WriteLine("hero Height" + heroHeight);
        int heroAge = 23;
        Console.WriteLine("hero Age" + heroAge);
        string heroSuperPower = "disappearness";
        Console.WriteLine("hero Super Power" + heroSuperPower);


        string villainName = "vie";
        Console.WriteLine("villain Name" + villainName);
        int vililanHeight = 190;
        Console.WriteLine("villain Height" + vililanHeight);
        int villainAge = 45;
        Console.WriteLine("villain Age" + villainAge);
        string villainSuperPower = "fast";
        Console.WriteLine("villainSuperPower" + villainSuperPower);
        string ageDifference = villainAge - heroAge;
        object value = Console.WriteLine("age diiference" + ageDifference);
    }
}