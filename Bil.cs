namespace repetition
{
    public class Bil: Fordon, IKörbar
    {
        private string modell;

        public string Modell{
            get{return modell;}
            set{modell = value;}
        }
        public Bil(string märke, string modell): base(märke)
        {
            this.modell = modell;
        }

        public void Kör()
        {
            Console.WriteLine($"{märke} kör som en {modell}!");
        }
    }
}