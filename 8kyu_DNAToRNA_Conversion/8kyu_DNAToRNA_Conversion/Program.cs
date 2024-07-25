namespace Converter
{
    public class Converter
    {
        public string DnaToRna(string dna)
        {
            if (string.IsNullOrEmpty(dna))
            {
                return string.Empty;
            }
            return dna.Replace('T', 'U');
        }
    }
}
