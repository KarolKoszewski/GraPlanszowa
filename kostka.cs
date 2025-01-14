namespace zadania;

public class Kostka
{
    public Kostka(int liczbagraczy, int liczbaOczekGracz1, int liczbaOczekGracz2, int liczbaOczekGracz3)
    {
        if (liczbagraczy == 2)
        {
            //gracz 1
            Random random = new Random();
            liczbaOczekGracz1 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 1 wylosował: {liczbaOczekGracz1} oczek");
            Console.Write("Aby kontynuować, naciśnij dowolny klawisz...");
            Console.ReadKey();
            Console.WriteLine("Kontynuujemy...");
            //gracz 2
            liczbaOczekGracz2 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 2 wylosował: {liczbaOczekGracz2} oczek");
            Console.Write("Aby kontynuować, naciśnij dowolny klawisz...");
            Console.ReadKey();
            Console.WriteLine("Kontynuujemy...");
        }
        
        if (liczbagraczy == 3)
        {
            //gracz 1
            Random random = new Random();
            liczbaOczekGracz1 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 1 wylosował: {liczbaOczekGracz1} oczek");
            Console.Write("Aby kontynuować, naciśnij dowolny klawisz...");
            Console.ReadKey();
            Console.WriteLine("Kontynuujemy...");
            //gracz 2
            liczbaOczekGracz2 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 2 wylosował: {liczbaOczekGracz2} oczek");
            Console.Write("Aby kontynuować, naciśnij dowolny klawisz...");
            Console.ReadKey();
            Console.WriteLine("Kontynuujemy...");
            //gracz 3
            liczbaOczekGracz3 = random.Next(1, 7);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gracz 3 wylosował: {liczbaOczekGracz3} oczek");
            Console.Write("Aby kontynuować, naciśnij dowolny klawisz...");
            Console.ReadKey();
            Console.WriteLine("Kontynuujemy...");
            
        }
    }

    public int liczbaOczekGracz1 { get; set; }
    public int liczbaOczekGracz2 { get; set; }
    public int liczbaOczekGracz3 { get; set; }
}