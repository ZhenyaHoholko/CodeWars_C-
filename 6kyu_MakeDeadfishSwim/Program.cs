//Create a parser to interpret and execute the Deadfish language.
//Deadfish operates on a single value in memory, which is initially set to 0.
//It uses four single-character commands:

//i: Increment the value
//d: Decrement the value
//s: Square the value
//o: Output the value to a result array
//All other instructions are no-ops and have no effect.

//Examples
//Program "iiisdoso" should return numbers [8, 64].
//Program "iiisdosodddddiso" should return numbers [8, 64, 3600].Create a parser to interpret and execute the Deadfish language.

//Deadfish operates on a single value in memory, which is initially set to 0.
//It uses four single-character commands:
//i: Increment the value
//d: Decrement the value
//s: Square the value
//o: Output the value to a result array
//All other instructions are no-ops and have no effect.

//Examples
//Program "iiisdoso" should return numbers [8, 64].
//Program "iiisdosodddddiso" should return numbers [8, 64, 3600].

using System;
using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        List<int> Result = new List<int>();
        int item = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i]== 'i') {item++;}
            else if (data[i]== 'd') {item--;}
            else if (data[i]== 's') {item=item*item; }
            else if (data[i]== 'o') { Result.Add(item); }
        }
        return Result.ToArray();
    }
}