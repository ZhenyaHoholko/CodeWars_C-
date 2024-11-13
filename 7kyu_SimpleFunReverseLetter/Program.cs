using System;
using System.Linq;
namespace myjinxin
{
    public class Kata
    {
        public string ReverseLetter(string str)
        {
            return new string(str.Where(char.IsLetter).Reverse().ToArray());
        }
    }
}