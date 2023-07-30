/*
 * LINK: https://www.codewars.com/kata/5d23d89906f92a00267bb83d/train/csharp
 * 
 * Some new cashiers started to work at your restaurant.
 * 
 * They are good at taking orders, but they don't know how to capitalize words, or use a space bar!
 * 
 * All the orders they create look something like this:
 * 
 * "milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"
 * 
 * The kitchen staff are threatening to quit, because of how difficult it is to read the orders.
 * 
 * Their preference is to get the orders as a nice clean string with spaces and capitals like so:
 * 
 * "Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"
 * 
 * The kitchen staff expect the items to be in the same order as they appear in the menu.
 * 
 * The menu items are fairly simple, there is no overlap in the names of the items:
 * 
 *      1. Burger
 *      2. Fries
 *      3. Chicken
 *      4. Pizza
 *      5. Sandwich
 *      6. Onionrings
 *      7. Milkshake
 *      8. Coke
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.New_Cashier_Does_Not_Know_About_Space_or_Shift
{
    public class NewCashierDoesNotKnowAboutSpaceOrShift
    {
        public static string GetOrder(string input)
        {
            string result = "";

            List<string> items = new List<string>()
            {
                "Burger",
                "Fries",
                "Chicken",
                "Pizza",
                "Sandwich",
                "Onionrings",
                "Milkshake",
                "Coke"
            };


            for (int i = 0; i < items.Count; i++)
            {
                int index = 0;
                int lastIndex = -1;

                while (index < input.Length)
                {
                    index = input.IndexOf(items[i].ToLower(), index);

                    if (lastIndex == index || index == -1)
                    {
                        break;
                    }

                    result += items[i] + " ";
                    lastIndex = index;
                    index += items[i].Length;
                }
            }
            return result.Substring(0, result.Length - 1);
        }
    }
}
