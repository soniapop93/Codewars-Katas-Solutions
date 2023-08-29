/*
 * LINK: https://www.codewars.com/kata/57f7f71a7b992e699400013f/train/csharp
 * 
 * You get a string with the content of a csv-file. The columns are separated by semicolons.
 * The first line contains the names of the columns.
 * Write a method that sorts the columns by the names of the columns alphabetically and incasesensitive.
 * 
 * An example:
 * 
 * Before sorting:
 * As table (only visualization):
 * |myjinxin2015|raulbc777|smile67|Dentzil|SteffenVogel_79|
 * |17945       |10091    |10088  |3907   |10132          |
 * |2           |12       |13     |48     |11             |
 * 
 * The csv-file:
 * myjinxin2015;raulbc777;smile67;Dentzil;SteffenVogel_79\n
 * 17945;10091;10088;3907;10132\n
 * 2;12;13;48;11
 * 
 * ----------------------------------
 * 
 * After sorting:
 * As table (only visualization):
 * |Dentzil|myjinxin2015|raulbc777|smile67|SteffenVogel_79|
 * |3907   |17945       |10091    |10088  |10132          |
 * |48     |2           |12       |13     |11             |
 * 
 * The csv-file:
 * Dentzil;myjinxin2015;raulbc777;smile67;SteffenVogel_79\n
 * 3907;17945;10091;10088;10132\n
 * 48;2;12;13;11
 * There is no need for prechecks. You will always get a correct string with more than 1 line und more than 1 row. 
 * All columns will have different names.
 */

using System.Collections.Generic;
using System;

namespace CodewarsKatas._6_kyu.SortTheColumnsOfACsvFile
{
    public class SortTheColumnsOfACsvFile
    {
        public static string SortCsvColumns(string csvFileContent)
        {
            string result = "";

            SortedDictionary<string, List<string>> csvContentDict = new SortedDictionary<string, List<string>>();

            string[] splitedRowsCsv = csvFileContent.Split("\n");

            string[] columns = splitedRowsCsv[0].Split(";");

            for (int i = 0; i < columns.Length; i++)
            {
                List<string> columnItems = new List<string>();

                for (int j = 1; j < splitedRowsCsv.Length; j++)
                {
                    string[] splittedRow = splitedRowsCsv[j].Split(";");

                    for (int k = i; k < splittedRow.Length; k++)
                    {
                        columnItems.Add(splittedRow[k]);
                        break;
                    }
                }
                csvContentDict[columns[i]] = columnItems;
            }

            foreach (string k in csvContentDict.Keys)
            {
                result += k + ";";
            }

            result = result.Substring(0, result.Length - 1);

            result += "\n";

            List<string> rowsAfterSort = csvContentDict[columns[0]];

            
            for (int i = 0; i < rowsAfterSort.Count; i++)
            {
                foreach (var kv in csvContentDict)
                {
                    result += kv.Value[i] + ";";
                }
                result = result.Substring(0, result.Length - 1);
                result += "\n";
            }

            return result.Substring(0, result.Length - 1);
        }
    }
}
