import static java.lang.Math.pow;
import static java.lang.Math.abs;
import static java.lang.Math.E;

import java.util.Scanner;

class LR5 {
    public static void main(String[] args) {
        double x, y, A, B, H, xMin, yMin;
        int N;

        Scanner scan = new Scanner(System.in);
        System.out.print("A = "); 
        A = scan.nextDouble();
        System.out.print("B = "); 
        B = scan.nextDouble();
        System.out.print("N = "); 
        N = scan.nextInt();
        scan.close();

        H = (B - A) / (N - 1);
        
        xMin = A;
        yMin = pow(A, 3) + pow(E, A) - 3;
        x = A;

        while (x <= B + (H / 2))
        {
            y = pow(x, 3) + pow(E, x) - 3;
            System.out.printf("%15.4f %15.4f\n", x, y);

            if (y < yMin)
            {
                xMin = x;
                yMin = y;
            }
            x += H;
        }
        System.out.printf("\nxMin = %1.4f yMin = %1.4f", xMin, yMin);
    }
}