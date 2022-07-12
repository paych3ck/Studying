import java.util.Scanner;
import java.util.Arrays;
import static java.lang.Math.abs;

public class lab5 {
    public static void main(String[] args) {
        double[][] X;
        double[] X_new;
        int N, M;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        System.out.print("M = ");
        M = scan.nextInt();
        int k = 0;

        X = new double[N][M];
        X_new = new double[k];

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < M; column++)
            {
                System.out.print("x(" + row + ", " + column + ") = ");
                X[row][column] = scan.nextDouble();
            }
        }

        scan.close();

        for (int row = 1; row < N; row += 2)
        {
            for (int column = 0; column < M; column++)
            {
                double element = X[row][column];
        
                if (element < row + column)
                {
                    X_new = Arrays.copyOf(X_new, X_new.length + 1);
                    X_new[k] = element;
                    k++;
                }
            }
        }

        System.out.println("+++++++++++++++");
        for (int i = 0; i < k; i++)
        {
            System.out.printf("X_new(%d) = %1.2f\n", i, X_new[i]);
        }
    }
}