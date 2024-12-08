// See https://aka.ms/new-console-template for more information

using zadania;

internal class Program
{
    public static void Main(string[] args)
    {
        PlayerWarrior gracz1 = new PlayerWarrior
        {
            Name = "Rafon",
            Position = 0,
            Score = 10,
        };
        Console.WriteLine(gracz1.Name);

        PlayerMag gracz2 = new PlayerMag()
        {
            Name = "Robalini",
            Position = 0,
            Score = 10,
        };
        Console.WriteLine(gracz2.Name);
        PlayerHealer gracz3 = new PlayerHealer()
        {
            Name = "Bagieta",
            Position = 0,
            Score = 10,
        };
        Console.WriteLine(gracz3.Name);
        
    }
}