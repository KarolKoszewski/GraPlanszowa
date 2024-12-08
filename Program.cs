// See https://aka.ms/new-console-template for more information

using zadania;

internal class Program
{
    //tworze graczy
    public static void Main(string[] args)
    {
        
        var nazwa = "Jakub";
        PlayerWarrior gracz1 = new PlayerWarrior
        {
            Name = "Rafon",
            Position = 0,
            Score = 10,
        };
        
        PlayerMag gracz2 = new PlayerMag()
        {
            Name = nazwa,
            Position = 0,
            Score = 10,
        };
        
        PlayerHealer gracz3 = new PlayerHealer()
        {
            Name = "Bagieta",
            Position = 0,
            Score = 10,
        };
        
        Console.WriteLine(gracz2.Name);
        Console.WriteLine("Wprowadź liczbę graczy, Pamietaj, że maksymalna Ilość graczy to 3:");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Wprowadź liczbę pól na planszy, Pamiętaj, że minimalna liczba pól to 35:");
        int b = int.Parse(Console.ReadLine());
        if (a > 3 || b < 35)
        {
            Console.WriteLine("Błąd! podaj właściwe wartości");
            Environment.Exit(0);
        }
        Game gra = new Game(a,b);
        
        
    }
}