using System;

namespace Intrument_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Guitar myGuitar = new Guitar("Gibson");
            Mandolin myMandolin = new Mandolin("Kentucky KM-140");
            Ukele myUkele = new Ukele("Ortega");

            myUkele.serialNumber = "abc123";

            myGuitar.Play();
            myMandolin.Play();
            myUkele.Play();
        }
    }
}
