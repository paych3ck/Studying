import static java.lang.Math.sin;
import static java.lang.Math.pow;
import static java.lang.Math.sqrt;

import java.util.Scanner;

class LR2_if_else {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
		System.out.print("a: ");   
        double a = scan.nextDouble();
        scan.close();
        double y = 0;

        if (a <= -10 || 1 <= a && a <= 8)
        {
            y = 1 - pow(a, 2);
        }

        else if (16 <= a && a <= 40 || a == 59 || a == 65)
        {
            y = sqrt(pow(a, 3) - 2) + 15;
        }

        else if (-8 <= a && a <= -2 || a == 50 || a == 60 || a >= 70)
        {
            y = sin(a - 3);
        }

        else
        {
            y = a - 10;
        }

        System.out.println("y: " + y);
    }
}