namespace zadania;

public class Kostka
{
    public Kostka(int liczbagraczy)
    {
        if (liczbagraczy == 2)
        {
            Random random = new Random();
            int liczbaOczekGracz1 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz wylosował: {liczbaOczekGracz1} oczek");
            
            int liczbaOczekGracz2 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz wylosował: {liczbaOczekGracz2} oczek");
        }
        
        if (liczbagraczy == 3)
        {
            Random random = new Random();
            int liczbaOczekGracz1 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 1 wylosował: {liczbaOczekGracz1} oczek");
            
            int liczbaOczekGracz2 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 2 wylosował: {liczbaOczekGracz2} oczek");
            
            int liczbaOczekGracz3 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 3 wylosował: {liczbaOczekGracz3} oczek");
        }
    }
    
}