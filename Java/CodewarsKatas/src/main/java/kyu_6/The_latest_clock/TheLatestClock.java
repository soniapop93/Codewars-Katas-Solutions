/*
LINK: https://www.codewars.com/kata/58925dcb71f43f30cd00005f/train/java

Write a function which receives 4 digits and returns the latest time of day
that can be built with those digits.

The time should be in HH:MM format.

Examples:

digits: 1, 9, 8, 3 => result: "19:38"
digits: 9, 1, 2, 5 => result: "21:59" (19:25 is also a valid time, but 21:59 is later)
Notes
Result should be a valid 24-hour time, between 00:00 and 23:59.
 */

package kyu_6.The_latest_clock;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;

public class TheLatestClock {
    public static String latestClock(int a, int b, int c, int d) {
        for (int i = 86400; i >= 0; i-=60) {
            Calendar day = Calendar.getInstance();
            day.set(Calendar.SECOND, i);
            day.set(Calendar.MINUTE, 0);
            day.set(Calendar.HOUR_OF_DAY, 0);

            SimpleDateFormat df = new SimpleDateFormat("HH:mm");
            String newTime = df.format(day.getTime());

            ArrayList<Integer> values = new ArrayList<>();
            values.add(a);
            values.add(b);
            values.add(c);
            values.add(d);

            ArrayList<Integer> newTimeValues = new ArrayList<>();

            for (int j = 0; j < newTime.length(); j++) {
                if (newTime.charAt(j) >= 48 && newTime.charAt(j) <= 57) {
                    newTimeValues.add(Integer.parseInt(String.valueOf(newTime.charAt(j))));
                }
            }

            Collections.sort(values);
            Collections.sort(newTimeValues);

            boolean sameValues = values.equals(newTimeValues);

            if (sameValues) {
                return newTime;
            }
        }
        return null;
    }
}