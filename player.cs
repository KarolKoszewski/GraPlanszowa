namespace zadania;

public class Player
{
    public string Name{get; set;}
    public int Position{get; set;}
    public int Score{get; set;}

    public Player(string name, int position, int score)
    {
        this.Name = name;
        this.Position = position;
        this.Score = score;
    }

    public Player()
    {
        Name = "bezimienny";
        Position = 0;
        Score = 0;
    }
}

public class PlayerWarrior : Player, IWarrior
{
    public PlayerWarrior()
    {
        this.Name = "Bezimienny";
        this.Position = 0;
        this.Score = 0;
    }

    public void GainMorePoints()
    {
        Score += 10;
    }
}

public class PlayerMag : Player, IMag
{
    public PlayerMag()
    {
        this.Name = "Bezimienny";
        this.Position = 0;
        this.Score = 0;
    }


    public void CastSpell()
    {
        Console.WriteLine("Casting Spell");
    }
}

public class PlayerHealer : Player, IHealer
{
    public PlayerHealer()
    {
        this.Name = "Bezimienny";
        this.Position = 0;
        this.Score = 0;
    }


    public void Heal()
    {
        Console.WriteLine("Healing");
    }
}