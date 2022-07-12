import java.util.Scanner;
import java.util.Arrays;
import static java.lang.Math.abs;

public class LR_6_3 {
    public static void main(String[] args) {
        double[] Z;
        double[] Y;
        int N, K, i;
        K = 0;
        boolean FlagSort;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        Z = new double[N];
        Y = new double[K];

        for (i = 0; i < N; i++)
        {
            System.out.print("Z(" + i + ") = ");
            Z[i] = scan.nextDouble();
        }

        scan.close();

        for (i = 1; i < N; i += 2)
        {
            if (Z[i] % 2 == 0)
            {
                Y = Arrays.copyOf(Y, Y.length + 1);
                Y[K] = Z[i];
                K++;
            }
        }

        System.out.println("Массив Yk:");
        for (i = 0; i < K; i++)
        {
            System.out.printf("Y(%d) = %1.2f\n", i, Y[i]);
        }
        
        do
        {
            FlagSort = true;

            for (i = 0; i <= N - 2; i++)
            {
                if (!(Z[i] <= Z[i + 1]))
                {
                    double y = Z[i];
                    Z[i] = Z[i + 1];
                    Z[i + 1] = y;
                    FlagSort = false;
                }
            }
        } while (!FlagSort);

        System.out.println("Отсортированный по возрастанию исходный массив Zn:");
        for (i = 0; i < N; i++)
        {
            System.out.printf("Z(%d) = %1.2f\n", i, Z[i]);
        }
    }
}