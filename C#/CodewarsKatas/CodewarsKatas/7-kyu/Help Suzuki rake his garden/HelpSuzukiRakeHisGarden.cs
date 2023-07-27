/*
 * LINK: https://www.codewars.com/kata/571c1e847beb0a8f8900153d/train/csharp
 * 
 * Help Suzuki rake his garden!
 * 
 * The monastery has a magnificent Zen garden made of white gravel and rocks and it is raked diligently everyday by the monks. 
 * Suzuki having a keen eye is always on the lookout for anything creeping into the garden that must be removed during the daily raking such as insects or moss.
 * 
 * You will be given a string representing the garden such as:
 * 
 * garden = 'gravel gravel gravel gravel gravel gravel gravel gravel gravel rock slug ant gravel gravel snail rock gravel gravel 
 * gravel gravel gravel gravel gravel slug gravel ant gravel gravel gravel gravel rock slug gravel gravel gravel gravel gravel snail gravel gravel 
 * rock gravel snail slug gravel gravel spider gravel gravel gravel gravel gravel gravel gravel gravel moss gravel gravel gravel snail gravel gravel gravel ant gravel gravel moss gravel gravel gravel gravel snail gravel gravel gravel gravel slug gravel rock gravel gravel rock gravel gravel gravel gravel snail gravel gravel rock gravel gravel gravel gravel gravel spider gravel rock gravel gravel'
 * Rake out any items that are not a rock or gravel and replace them with gravel such that:
 * 
 * garden = 'slug spider rock gravel gravel gravel gravel gravel gravel gravel'
 * Returns a string with all items except a rock or gravel replaced with gravel:
 * 
 * garden = 'gravel gravel rock gravel gravel gravel gravel gravel gravel gravel'
 * 
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Help_Suzuki_rake_his_garden
{
    public class HelpSuzukiRakeHisGarden
    {
        public static string RakeGarden(string garden)
        {
            string[] gardenArray = garden.Split(" ");
            List<string> result = new List<string>();

            for (int i = 0; i < gardenArray.Length; i++)
            {
                if (!gardenArray[i].Equals("rock") && !gardenArray[i].Equals("gravel"))
                {
                    result.Add("gravel");
                }
                else
                {
                    result.Add(gardenArray[i]);
                }
            }

            return String.Join(" ", result);
        }
    }
}
