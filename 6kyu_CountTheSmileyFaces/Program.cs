//Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
//Rules for a smiling face:
//Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or;
//A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
//Every smiling face must have a smiling mouth that should be marked with either ) or D
//No additional characters are allowed except for those mentioned.
//Valid smiley face examples: :) :D; -D :~)
//Invalid smiley faces: ; ( :> :} :]
//Example
//countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
//countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
//countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
//Note
//In case of an empty array return 0. You will not be tested with invalid input (input will always be an array). 
//Order of the face (eyes, nose, mouth) elements will always be the same.

using System;
using System.Linq;

public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        int count = 0;
        char[] validEyes = { ';', ':' };
        char[] validNoses = { '-', '~' };
        char[] validMouths = { 'D', ')' };

        foreach (string smiley in smileys)
        {
            if (smiley.Length == 2)
            {
                if (validEyes.Contains(smiley[0]) && validMouths.Contains(smiley[1]))
                {
                    count++;
                }
            }
            else if (smiley.Length == 3)
            {
                if (validEyes.Contains(smiley[0]) && validNoses.Contains(smiley[1]) && validMouths.Contains(smiley[2]))
                {
                    count++;
                }
            }
        }
        return count;
    }
}
