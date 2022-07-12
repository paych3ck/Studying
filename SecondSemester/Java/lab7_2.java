import java.util.Scanner;
import java.util.Arrays;

public class a_lab7_2 {
    public static void main(String[] args) {
        double[][] x;
        double[] x_new;
        double s;
        int N, M, k;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        System.out.print("M = ");
        M = scan.nextInt();
        k = 0;

        x = new double[N][M];
        x_new = new double[k];

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < M; column++)
            {
                System.out.print("x(" + row + ", " + column + ") = ");
                x[row][column] = scan.nextDouble();
            }
        }

        scan.close();

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < M; column++)
            {
                System.out.printf("%6.2f", x[row][column]);
            }
            System.out.println();
        }

        for (int row = 0; row < N; row += 2)
        {
            s = 0;

            for (int column = 0; column < M; column++)
            {
                if (x[row][column] % 2 != 0)
                {
                    s += x[row][column];
                }
            }
            
            if (s != 0)
            {
                x_new = Arrays.copyOf(x_new, x_new.length + 1);
                x_new[k] = s;
                k++;
            }
        }

        for (int i = 0; i < k; i++)
        {
            System.out.printf("x(%d) = %1.2f\n", i, x_new[i]);
        }
    }
}