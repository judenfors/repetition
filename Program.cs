using repetition;

List<IKörbar> körbarlista = new();


/*

*/

IKörbar f1 = new Bil("BMWn", "AMG");

Cukel f2 = new Cukel("Min");

Spel doom = new Doom();

körbarlista.Add(doom);
körbarlista.Add(f1);
körbarlista.Add(f2);

foreach (var körbar in körbarlista)
{
    körbar.Kör();
}


