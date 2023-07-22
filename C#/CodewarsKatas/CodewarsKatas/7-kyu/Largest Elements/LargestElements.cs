/*
 * LINK: https://www.codewars.com/kata/53d32bea2f2a21f666000256/train/csharp
 * 
 * Write a program that outputs the top n elements from a list.
 * 
 * Example:
 * 
 * Kata.Largest(2, new List<int> {7, 6, 5, 4, 3, 2, 1}) => new List<int> {6, 7}
 */

namespace CodewarsKatas._7_kyu.Largest_Elements
{
    public class LargestElements
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            List<int> result = new List<int>();

            List<int> orderedListDescendent = orderDescendent(xs);

            for (int i = 0; i < n; i++)
            {
                result.Add(orderedListDescendent[i]);
            }

            return orderAscendent(result);
        }

        private static List<int> orderDescendent(List<int> xs)
        {
            bool sorted = true;

            do
            {
                sorted = true;
                for (int i = 0; i < xs.Count - 1; i++)
                {
                    if (xs[i] < xs[i + 1])
                    {
                        int aux = xs[i];

                        xs[i] = xs[i + 1];
                        xs[i + 1] = aux;
                        sorted = false;
                        break;
                    }
                    else if (xs[i] > xs[i + 1])
                    {
                        continue;
                    }
                }
            } while (!sorted);

            return xs;
        }

        private static List<int> orderAscendent(List<int> orderedListDescendent)
        {
            bool sorted = true;

            do
            {
                sorted = true;
                for (int i = 0; i < orderedListDescendent.Count - 1; i++)
                {
                    if (orderedListDescendent[i] > orderedListDescendent[i + 1])
                    {
                        int aux = orderedListDescendent[i];

                        orderedListDescendent[i] = orderedListDescendent[i + 1];
                        orderedListDescendent[i + 1] = aux;
                        sorted = false;
                        break;
                    }
                    else if (orderedListDescendent[i] < orderedListDescendent[i + 1])
                    {
                        continue;
                    }
                }
            } while (!sorted);

            return orderedListDescendent;
        }
    }
}
