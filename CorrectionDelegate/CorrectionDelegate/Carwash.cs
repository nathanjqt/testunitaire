namespace CorrectionDelegate;

delegate void Traitement(Voiture v);

public class Carwash
{
    public void Traiter(Voiture v)
    {
        Traitement t = Preparer;
        t += Laver;
        t += Secher;
        t += Finaliser;

        t(v);
    }
    
    public void Traiter2(Voiture v)
    {
        Traitement t = delegate (Voiture v)
            {
                Console.WriteLine($"Je prepare la voiture {v.Plaque}");
            };
        t += delegate (Voiture v)
            {
                Console.WriteLine($"Je Laver la voiture {v.Plaque}");
            };
        t += delegate (Voiture v)
            {
                Console.WriteLine($"Je Secher la voiture {v.Plaque}");
            };
        t += delegate (Voiture v)
            {
                Console.WriteLine($"Je Finalise la voiture {v.Plaque}");
            };

        t(v);
    }
    
    private void Preparer(Voiture v)
    {
        Console.WriteLine($"Je prepare la voiture {v.Plaque}");
    }
    
    private void Laver(Voiture v)
    {
        Console.WriteLine($"Je Laver la voiture {v.Plaque}");
    }
    
    private void Secher(Voiture v)
    {
        Console.WriteLine($"Je Secher la voiture {v.Plaque}");
    }
    
    private void Finaliser(Voiture v)
    {
        Console.WriteLine($"Je  la voiture {v.Plaque}");
    }
}