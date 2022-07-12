import static java.lang.Math.pow;

import java.util.Scanner;

class LR3_1_for {
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

        for (int i = 1; i <= N; i++) 
        {
            P = P * (a - i);
            S1 = S1 + pow(i - 1, 2);
        }

        S2 = 0;
        
        for (int k = 2; k <= M; k++) 
        {
            S2 = S2 + (k / 2.0);
        }

        y = 2 * P + S1 + S2;
        System.out.println("y = " + y);
    }
}