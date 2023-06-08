
/*
 * LINK: https://www.codewars.com/kata/56484848ba95170a8000004d/train/csharp
 * 
 * In John's car the GPS records every s seconds the distance travelled from an origin (distances are measured in an arbitrary but consistent unit). 
 * For example, below is part of a record with s = 15:
 * 
 * x = [0.0, 0.19, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25]
 * The sections are:
 * 
 * 0.0-0.19, 0.19-0.5, 0.5-0.75, 0.75-1.0, 1.0-1.25, 1.25-1.50, 1.5-1.75, 1.75-2.0, 2.0-2.25
 * We can calculate John's average hourly speed on every section and we get:
 * 
 * [45.6, 74.4, 60.0, 60.0, 60.0, 60.0, 60.0, 60.0, 60.0]
 * Given s and x the task is to return as an integer the *floor* of the maximum average speed per hour obtained on the sections of x. If x length is less than or equal to 1 return 0 since the car didn't move.
 * 
 * Example:
 * With the above data your function gps(s, x) should return 74
 * 
 * Note
 * With floats it can happen that results depends on the operations order. To calculate hourly speed you can use:
 * 
 *  (3600 * delta_distance) / s
 */

using System;
using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Speed_Control
{
    public class SpeedControl
    {
        public static int Gps(int s, double[] x)
        {
            List<double> speedList = new List<double>();

            for (int i = 0; i < x.Length; i++)
            {
                if (i != x.Length - 1)
                {
                    double deltaDistance = Math.Abs(x[i] - x[i + 1]);
                    speedList.Add((3600 * deltaDistance) / s);
                }
            }

            double maxValue = 0;
            for (int j = 0; j < speedList.Count; j++)
            {
                if (speedList[j] > maxValue)
                {
                    maxValue = speedList[j];
                }
            }
            return (int)Math.Floor(maxValue);
        }
    }
}
