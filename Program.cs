// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using zadania;

internal class Program
{
    //tworze graczy
    public static void Main(string[] args)
    {
        PlayerWarrior ork = new PlayerWarrior
        {
            Name = "Ciemny Ork",
            Position = 0,
            Score = 10,
        };
        
        PlayerMag czarodziej = new PlayerMag()
        {
            Name = "Gandalf",
            Position = 0,
            Score = 10,
        };
        
        PlayerHealer lekarz = new PlayerHealer()
        {
            Name = "Czarny medyk",
            Position = 0,
            Score = 10,
        };
        
        Console.WriteLine("-------------------------");
        Console.WriteLine("Wprowadź liczbę graczy, Pamietaj, że maksymalna Ilość graczy to 3:");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("-------------------------");
        Console.WriteLine("Wprowadź liczbę pól na planszy, Pamiętaj, że minimalna liczba pól to 35:");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("-------------------------");
        Console.WriteLine("Wprowadź liczbę pól specjalnych: ");
        int c = int.Parse(Console.ReadLine());
        
        Board plansza = new Board(b,c);
        if (a > 3 || b < 35)
        {
            Console.WriteLine("Błąd! podaj właściwe wartości");
            Environment.Exit(0);
        }
        Game gra = new Game(a,b);
        
        
        Kostka dice = new Kostka(a,0,0,0);
        do
        {
            ork.Position = ork.Position + dice.liczbaOczekGracz1;
            czarodziej.Position = czarodziej.Position + dice.liczbaOczekGracz2;
            lekarz.Position = lekarz.Position + dice.liczbaOczekGracz3;
        } while (ork.Position!=b || czarodziej.Position!=b || lekarz.Position!=b);
        Console.WriteLine("Koniec gry");





    }
}