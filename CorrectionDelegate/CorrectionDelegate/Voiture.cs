namespace CorrectionDelegate;

public class Voiture
{
    public string Plaque { get; private set; }

    public Voiture(string plaque)
    {
        this.Plaque = plaque;
    }
}