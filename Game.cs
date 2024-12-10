namespace zadania;

public class Game
{
    public Game(int numberOfPlayers, int boardSize)
    {
        Console.WriteLine("\n-------------------------");
        Console.WriteLine("Witam!! Zaczynamy grę");
        Console.Write("Aby kontynuować, naciśnij dowolny klawisz...");
        Console.ReadKey();
        
        Console.WriteLine("Kontynuujemy...");

        if (numberOfPlayers == 1)
        {
            Console.WriteLine("Za mało Graczy!!");
            Environment.Exit(0);
        }

        if (numberOfPlayers > 3)
        {
            Console.WriteLine("Za dużo Graczy!!");
            Environment.Exit(0);
        }
        for (int i = 1; i < numberOfPlayers+1; i++)
        {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine($"Gracz{i} Wybiera Postać ");
                Console.WriteLine("1. Ork");
                Console.WriteLine("2. Czarodziej");
                Console.WriteLine("3. Lekarz");
            
                ConsoleKeyInfo key = Console.ReadKey(true);
            
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"Postać gracza{i} jest: Ork");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"Postać gracza{i} jest: Czarodziej ");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"Postać gracza{i} jest: Lekarz");
                        break;
                    default:
                        Console.WriteLine("ccc");
                        break;
                }
        }
        
    }
}