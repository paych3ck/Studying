import static java.lang.Math.pow;
import java.util.Scanner;

class lab3 {
    public static void main(String[] args) {
        double i, j, P1, P2, S, k, y;
        Scanner scan = new Scanner(System.in);
		System.out.print("L: ");   
		double L = scan.nextDouble();
		System.out.print("M: ");   
		double M = scan.nextDouble();

        i = 1;
        P1 = 1;
        do
        {
            P1 = P1 * ((i + 2 * M) / (pow(i, 2) + i));
            i++;
        }
        while (i <= M);

        k = 1;
        S = 0;
        do
        {
            S = S + ((2 * k + pow(M, 2)) / (M + k + 1));
            k++;
        }
        while (k <= M);

        j = 0;
        P2 = 1;
        do
        {
            P2 *= ((pow(j, 2) + 2) / (j + 1));
            j += 1;
        }
        while (j <= L);
        
        y = P1 + S + P2;

        System.out.println(y);
    }
}