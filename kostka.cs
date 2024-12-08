namespace zadania;

public class Kostka
{
    private Random random = new Random();
    public int Roll()
    {
        return random.Next(1, 7);
    }
}