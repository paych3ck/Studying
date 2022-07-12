import java.util.Scanner;
import java.util.Arrays;

public class lab6 {
    public static void main(String[] args) {
        double[][] X;
        int N;
        double s;
        int k;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        s = 0;
        k = 0;
        X = new double[N][N];

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                System.out.print("x(" + row + ", " + column + ") = ");
                X[row][column] = scan.nextDouble();
            }
        }

        scan.close();

        System.out.println("\nИсходная матрица:");
        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                System.out.printf("%6.2f", X[row][column]);
            }
            System.out.println();
        }

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                if (X[row][column] % 1 != 0)
                {
                    s += X[row][column];
                    k += 1;
                }
            }
        }

        if (k == 0)
        {
            System.out.println("\nОшибка.");
        }

        else
        {
            System.out.println("\nСреднее арифметическое: " + s / k);

            for (int i = 0; i < N; i++)
            {
                X[i][N - i - 1] = s / k;
            }

            System.out.println("\nОтредактированная матрица:");
            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    System.out.printf("%6.2f", X[row][column]);
                }
                System.out.println();
            }
        }
    }
}