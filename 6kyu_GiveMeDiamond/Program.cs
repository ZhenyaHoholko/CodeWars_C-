//Jamie is a programmer, and James' girlfriend. She likes diamonds, and wants a diamond string from James. Since James doesn't know how to make this happen, he needs your help.

//Task
//You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters.
//    Trailing spaces should be removed, and every line must be terminated with a newline character (\n).

//Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.

//Examples
//A size 3 diamond:

// *
//***
// *
//...which would appear as a string of " *\n***\n *\n"
using System;
using System.Text;

public class Diamond
{
    public static string print(int n)
    {
        if (n <= 0 || n % 2 == 0)
        {
            return null;
        }

        StringBuilder diamond = new StringBuilder();
        int mid = n / 2;

        for (int i = 0; i < n; i++)
        {
            int stars = i <= mid ? 1 + 2 * i : 1 + 2 * (n - i - 1);
            int spaces = (n - stars) / 2;

            diamond.Append(new string(' ', spaces));
            diamond.Append(new string('*', stars));
            diamond.Append('\n');
        }

        return diamond.ToString();
    }
}
