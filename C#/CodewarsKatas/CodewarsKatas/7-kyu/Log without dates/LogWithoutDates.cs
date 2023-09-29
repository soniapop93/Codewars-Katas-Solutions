/*
 * LINK: https://www.codewars.com/kata/64cac86333ab6a14f70c6fb6/train/csharp
 * 
 * You will be given an array of events, which are represented by strings. The strings are dates in HH:MM:SS format.
 * 
 * It is known that all events are recorded in chronological order and two events can't occur in the same second.
 * 
 * Return the minimum number of days during which the log is written.
 * 
 * Example:
 * 
 * Input -> ["00:00:00", "00:01:11", "02:15:59", "23:59:58", "23:59:59"]
 * Output -> 1
 * 
 * Input -> ["12:12:12"]
 * Output -> 1
 * 
 * Input -> ["12:00:00", "23:59:59", "00:00:00"]
 * Output -> 2
 * 
 * Input -> []
 * Output -> 0
 */

namespace CodewarsKatas._7_kyu.Log_without_dates
{
    public class LogWithoutDates
    {
        public static int CheckLogs(string[] log)
        {
            if (log.Length == 0)
            { 
                return 0;
            }

            int result = 1;

            for (int i = 0; i < log.Length - 1; i++)
            {
                if (log[i] == log[i + 1])
                {
                    result++;
                }
                else
                {
                    string[] splittedLogFirst = log[i].Split(":");
                    string[] splittedLogSecond = log[i + 1].Split(":");

                    int firstSplittedLogHour = Int32.Parse(splittedLogFirst[0]);
                    int secondSplittedLogHour = Int32.Parse(splittedLogSecond[0]);

                    if (firstSplittedLogHour > secondSplittedLogHour)
                    {
                        result++;
                    }
                    else if (firstSplittedLogHour == secondSplittedLogHour)
                    {
                        int firstSplittedLogMinute = Int32.Parse(splittedLogFirst[1]);
                        int secondSplittedLogMinute = Int32.Parse(splittedLogSecond[1]);

                        if (firstSplittedLogMinute > secondSplittedLogMinute)
                        {
                            result++;
                        }
                        else if (firstSplittedLogMinute == secondSplittedLogMinute)
                        {
                            int firstSplittedLogSecond = Int32.Parse(splittedLogFirst[2]);
                            int secondSplittedLogSecond = Int32.Parse(splittedLogSecond[2]);

                            if (firstSplittedLogSecond > secondSplittedLogSecond)
                            {
                                result++;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
