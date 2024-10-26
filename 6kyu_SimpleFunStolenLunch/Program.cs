namespace myjinxin
{
    using System;

    public class Kata
    {
        public string StolenLunch(string note)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            char[] ar = note.ToCharArray();

            for (int i = 0; i < ar.Length; i++)
            {
                if (char.IsDigit(ar[i]))
                {
                    ar[i] = letters[ar[i] - '0'];
                }
                else if (ar[i] >= 'a' && ar[i] <= 'j')
                {
                    ar[i] = (char)('0' + Array.IndexOf(letters, ar[i]));
                }
            }

            return new string(ar);
        }
    }
}
