namespace repetition
{
    public class Cukel: Fordon, IKörbar
    {
        public Cukel(string märke): base(märke){

        }
        public void Kör()
        {
            Console.WriteLine($"{märke} cykel trampar iväg");
        }
    }
}