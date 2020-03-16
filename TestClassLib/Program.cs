using Gatter;
using System;

namespace TestClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            NotGatter not = new NotGatter();
            not.eingeben(false);
            not.berechnen();
            Console.WriteLine(not.ausgebenSF());

            AndGatter and = new AndGatter();
            and.eingeben(false);
            and.berechnen();
            Console.WriteLine(and.ausgebenSF());

            NandGatter nand = new NandGatter();
            nand.eingeben(false);
            nand.berechnen();
            Console.WriteLine(nand.ausgebenSF());

            Console.WriteLine(NandGatter.Berechnen(false, true));

            Console.ReadLine();
        }
    }
}
