namespace repetition
{
    public class Doom: Spel
    {
        public Doom()
        {
            titel = "Doom";
        }

        public override void Kör()
        {
            Console.WriteLine("Doomslayer dödar demoner");
        }
    }
}