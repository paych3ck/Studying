import java.util.Scanner;
import java.util.Arrays;

public class a_lab9_2 {
    public static double[] new_arrayZ(int N) {
        double[] Z;
        double[] Y;
        int K;
        K = 0;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = " + N);
        Z = new double[N];
        Y = new double[K];

        for (int i = 0; i < N; i++)
        {
            System.out.print("Z(" + i + ") = ");
            Z[i] = scan.nextDouble();
        }

        scan.close();

        for (int i = 1; i < N; i += 2)
        {
            if (Z[i] % 2 == 0)
            {
                Y = Arrays.copyOf(Y, Y.length + 1);
                Y[K] = Z[i];
                K++;
            }
        }

        System.out.println("Массив Yk:");
        for (int i = 0; i < K; i++)
        {
            System.out.printf("Y(%d) = %1.2f\n", i, Y[i]);
        }

        return null;
    }
    public static void main(String[] args) {
        new_arrayZ(10);
    }
}