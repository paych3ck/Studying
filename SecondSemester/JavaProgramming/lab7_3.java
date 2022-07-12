import java.util.Scanner;

public class a_lab7_3 {
    public static void main(String[] args) {
        double[][] x;
        double[][] xT;
        double s;
        int N, M;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        System.out.print("M = ");
        M = scan.nextInt();
        s = 0;

        x = new double[N][M];
        xT = new double[M][N];

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

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < M; column++)
            {
                xT[column][row] = x[row][column];
            }
        }

        int NT = M;
        int MT = N;

        System.out.println("------------------");

        for (int row = 0; row < NT; row++)
        {
            for (int column = 0; column < MT; column++)
            {
                System.out.printf("%6.2f", xT[row][column]);
            }
            System.out.println();
        }

        for (int row = 0; row < NT; row++)
        {
            s += xT[row][row];
        }

        for (int row = 0; row < NT; row++)
        {
            for (int column = 0; column < MT; column++)
            {
                if (xT[row][column] > 0)
                {
                    xT[row][column] = s;
                }
            }
        }

        System.out.println("------------------");

        for (int row = 0; row < NT; row++)
        {
            for (int column = 0; column < MT; column++)
            {
                System.out.printf("%6.2f", xT[row][column]);
            }
            System.out.println();
        }
    }
}