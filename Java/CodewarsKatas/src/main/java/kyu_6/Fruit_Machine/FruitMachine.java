/*
LINK: https://www.codewars.com/kata/590adadea658017d90000039/train/java


Introduction
Slot machine (American English), informally fruit machine (British English), puggy (Scottish English slang),
the slots (Canadian and American English), poker machine (or pokies in slang)
(Australian English and New Zealand English) or simply slot (American English), is a casino gambling machine with three
or more reels which spin when a button is pushed. Slot machines are also known as one-armed bandits because they were
originally operated by one lever on the side of the machine as distinct from a button on the front panel, and because
of their ability to leave the player in debt and impoverished. Many modern machines are still equipped with a legacy
lever in addition to the button. (Source Wikipedia)

Task
You will be given three reels of different images and told at which index the reels stop. From this information your
job is to return the score of the resulted reels.
Rules
1. There are always exactly three reels

2. Each reel has 10 different items.

3. The three reel inputs may be different.

4. The spin array represents the index of where the reels finish.

5. The three spin inputs may be different

6. Three of the same is worth more than two of the same

7. Two of the same plus one "Wild" is double the score.

8. No matching items returns 0.

Returns
Return an integer of the score.
Example
Initialise
reel1 = {"Wild","Star","Bell","Shell","Seven","Cherry","Bar","King","Queen","Jack"}
reel2 = {"Wild","Star","Bell","Shell","Seven","Cherry","Bar","King","Queen","Jack"}
reel3 = {"Wild","Star","Bell","Shell","Seven","Cherry","Bar","King","Queen","Jack"}
spin  = {5,5,5}
result = fruit({reel1, reel2, reel3}, spin)
Scoring
reel1[5] == "Cherry"
reel2[5] == "Cherry"
reel3[5] == "Cherry"

Cherry + Cherry + Cherry == 50
Return
result == 50
 */

package kyu_6.Fruit_Machine;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class FruitMachine {
    public static int fruit(final String[][] reels, final int[] spins) {
        Map<String, Integer> points = getPointsMap();
        int rowIndex = 0;

        ArrayList<String> winningItems = new ArrayList<>();

        for (int i = 0; i < spins.length; i++) {
            winningItems.add(reels[rowIndex][spins[i]]);
            rowIndex++;
        }

        HashMap<String, Integer> winningPoints = new HashMap<>();

        for (int i = 0; i < winningItems.size(); i++) {
            if (!winningPoints.containsKey(winningItems.get(i))) {
                winningPoints.put(winningItems.get(i), 1);
            }
            else {
                winningPoints.put(winningItems.get(i), winningPoints.get(winningItems.get(i)) + 1);
            }
        }

        int resultPoints = 0;

        if (winningPoints.size() == 1) {
            resultPoints += points.get(winningPoints.keySet().toArray()[0]);
        }

        if (winningPoints.size() == 2) {
            Object[] pointsArr = winningPoints.keySet().toArray();
            if (winningPoints.containsKey("Wild")) {
                if (winningPoints.get("Wild") == 2) {
                    return points.get("Wild") / 10;
                } else {
                    resultPoints += (points.get(pointsArr[0].equals("Wild") ? pointsArr[1] : pointsArr[0]) / 10) * 2;
                }
            } else {
                resultPoints += points.get(winningPoints.get(pointsArr[0]) == 2 ? pointsArr[0] : pointsArr[1]) / 10;
            }
        }

        return resultPoints;
    }

    private static Map<String, Integer> getPointsMap() {
        Map<String, Integer> points = new HashMap<>();
        points.put("Wild", 100);
        points.put("Star", 90);
        points.put("Bell", 80);
        points.put("Shell", 70);
        points.put("Seven", 60);
        points.put("Cherry", 50);
        points.put("Bar", 40);
        points.put("King", 30);
        points.put("Queen", 20);
        points.put("Jack", 10);

        return points;
    }
}
