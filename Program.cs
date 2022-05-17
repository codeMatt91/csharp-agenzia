using System;

namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenzia agenzia1 = new Agenzia("Agenzia Fll. Rossi");
            Appartamento app1 = new Appartamento("SJD234", "via roma 1", "00100", "Roma", 85, 4, 1);
            Box box1 = new Box("SDM443", "via garibaldi 15", "00150", "Roma", 65, 2);
            Villa villa3 = new Villa("GTY560", "via nazionale 10", "00189", "Roma", 110, 4, 2,40);

            agenzia1.AddImmobile(app1);
            agenzia1.AddImmobile(box1);
            agenzia1.AddImmobile(villa3);


            agenzia1.CercaImmobile("dfgdf");
        }
    }
}
