import java.util.Scanner;
import static java.lang.Math.pow;

class LR3_2 {
    public static void main(String[] args) {
        double y, P, S;
        Scanner scan = new Scanner(System.in);
        System.out.print("M: ");
        int M = scan.nextInt();
        System.out.print("N: ");
        int N = scan.nextInt();
        System.out.print("b: ");
        double b = scan.nextDouble();
        scan.close();
        
        P = 1;
        for (int i = 1; i <= N; i++)
        {
            S = 0;
        
            for (int j = 1; j <= M; j++)
            {
                S = S + (2 * i + pow(j, b));
            }
        
            P = P * (i + S);
        }
        y = P;
        System.out.println("y: " + y);
    }
}