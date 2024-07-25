using System;

namespace Converter
{
    public class Program
    {
        public static void Main()
        {
            string dna = "GUTGCCAT";
            string rna = Converter.DnaToRna(dna);
            Console.WriteLine(rna);

            string dna2 = "GATTACA";
            Console.WriteLine(Converter.DnaToRna(dna2));
        }
    }
}
