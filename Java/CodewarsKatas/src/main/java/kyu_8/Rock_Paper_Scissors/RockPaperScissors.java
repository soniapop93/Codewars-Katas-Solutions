/*
LINK: https://www.codewars.com/kata/5672a98bdbdd995fad00000f/train/java

Let's play! You have to return which player won! In case of a draw return Draw!.

Examples(Input1, Input2 --> Output):

"scissors", "paper" --> "Player 1 won!"
"scissors", "rock" --> "Player 2 won!"
"paper", "paper" --> "Draw!"
 */

package kyu_8.Rock_Paper_Scissors;

public class RockPaperScissors {
    public static String rps(String p1, String p2) {
        if (p1.equals(p2)) {
            return "Draw!";
        }
        else if ((p1.equals("scissors") && p2.equals("paper")) ||
                 (p1.equals("paper") && p2.equals("rock")) ||
                 (p1.equals("rock") && p2.equals("scissors"))) {
            return "Player 1 won!";
        }
        else {
            return "Player 2 won!";
        }
    }
}
