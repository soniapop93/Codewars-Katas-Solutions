/*
 * LINK: https://www.codewars.com/kata/583203e6eb35d7980400002a/train/csharp
 * 
 * Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
 * 
 * Rules for a smiling face:
 * 
 * Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
 * A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
 * Every smiling face must have a smiling mouth that should be marked with either ) or D
 * No additional characters are allowed except for those mentioned.
 * 
 * Valid smiley face examples: :) :D ;-D :~)
 * Invalid smiley faces: ;( :> :} :]
 * 
 * Example:
 *      countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
 *      countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
 *      countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
 *      
 * Note:
 * 
 * In case of an empty array return 0. You will not be tested with invalid input (input will always be an array). 
 * Order of the face (eyes, nose, mouth) elements will always be the same.
 * 
 */

namespace CodewarsKatas._6_kyu.Count_the_smiley_faces
{
    public class CountTheSmileyFaces
    {
        public static int CountSmileys(string[] smileys)
        {
            int countResult = 0;

            for (int i = 0; i < smileys.Length; i++)
            {
                if (smileys[i].Length == 2)
                {
                    if ((smileys[i][0].ToString().Equals(":") || smileys[i][0].ToString().Equals(";")) &&
                        (smileys[i][1].ToString().Equals(")") || smileys[i][1].ToString().Equals("D")))
                    {
                        countResult++;
                    }
                }
                else if (smileys[i].Length == 3)
                {
                    if ((smileys[i][0].ToString().Equals(":") || smileys[i][0].ToString().Equals(";")) &&
                        (smileys[i][1].ToString().Equals("-") || smileys[i][1].ToString().Equals("~")) &&
                        (smileys[i][2].ToString().Equals(")") || smileys[i][2].ToString().Equals("D")))
                    {
                        countResult++;
                    }
                }
            }

            return countResult;
        }
    }
}
