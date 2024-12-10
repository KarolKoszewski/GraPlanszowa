using System.Collections;
using System.ComponentModel;

namespace zadania;

public class Board
{
    public Board(int wielkoscPlanszy, int liczbaPolSpecjalnych)
    {
        List<int> listaPolSpecjalnych = new List<int>();
        Random random = new Random();
        
        for (int i = 0; i < liczbaPolSpecjalnych; i++)
        {
            int liczba = random.Next(1, wielkoscPlanszy + 1); // Zakładam, że zakres dotyczy wielkości planszy
            listaPolSpecjalnych.Add(liczba);
        }

        Console.WriteLine("Pola specjalne: " + string.Join(", ", listaPolSpecjalnych));
    }
}  