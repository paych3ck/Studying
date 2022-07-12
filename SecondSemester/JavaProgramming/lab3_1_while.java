import static java.lang.Math.pow;

import java.util.Scanner;

class LR3_1 {
    public static void main(String[] args) {
        int N, M;
        double P, S1, S2, a, y;
        Scanner scan = new Scanner(System.in);
        System.out.print("M = "); 
        M = scan.nextInt();
        System.out.print("N = "); 
        N = scan.nextInt();
        System.out.print("a = "); 
        a = scan.nextDouble();
        scan.close();

        P = 1;
        S1 = 0;
        int i = 1;

        while (i <= N) 
        {
            P = P * (a - i);
            S1 = S1 + pow(i - 1, 2);
            i++;
        }

        S2 = 0;
        int k = 2;

        while (k <= M) 
        {
            S2 = S2 + (k / 2.0);
            k++;
        }

        y = 2 * P + S1 + S2;
        System.out.println("y = " + y);
        }
    }