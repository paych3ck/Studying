import java.util.Scanner;
import java.util.Arrays;

public class a_lab7_1 {
    public static void main(String[] args) {
        double[][] x;
        double s;
        int N, k, M;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        System.out.print("M = ");
        M = scan.nextInt();

        x = new double[N][M];

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

        for (int column = 0; column < M; column++)
        {
            s = 0;
            k = 0;

            for (int row = 0; row < N; row++)
            {
                k += 1;
                s += x[row][column];
            }

            if (s / k > 0)
            {
                System.out.println("Столбец: " + column + ", среднее арифметическое: " + s / k);
            }
        }
    }
}