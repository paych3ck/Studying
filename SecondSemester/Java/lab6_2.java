import java.util.Scanner;
import java.util.Arrays;
import static java.lang.Math.abs;

public class LR_6_2 {
    public static void main(String[] args) {
        double[] y;
        double S, avg, k;
        int N, NewN;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        y = new double[N];
        NewN = 0;

        for (int i = 0; i < N; i++)
        {
            System.out.print("y(" + i + ") = ");
            y[i] = scan.nextDouble();
        }

        scan.close();
        S = 0;
        k = 0;

        for (int i = 0; i < N; i++)
        {
            if (y[i] > 0)
            {
                S += y[i];
                k++;
            }
        }

        if (k == 0)
        {
            System.out.println("Ошибка.");
        }

        else
        {
            avg = S/k;
            System.out.printf("avg = %1.4f\n", avg);
            System.out.printf("Новый массив\n");

            for (int i = 1; i < N; i += 2)
            {
                if (y[i] > 0)
                {
                    y[i]= avg;
                }
            }

            for (int i = 0; i < N; i++)
            {
                System.out.printf("y(%d) = %1.2f\n", i, y[i]);
            }
        }

        for (int i = 0; i < N; i++)
        {
            if (y[i] % 2 != 0)
            {
                y[NewN] = y[i];
                NewN++;
            }
        }

        y = Arrays.copyOf(y, NewN);

        if (NewN != 0)
        {
            System.out.println("Измененный массив:");

            for (int i = 0; i < NewN; i++)
            {
                System.out.printf("y(%d) = %1.2f\n", i, y[i]);
            }
        }

        System.out.println("****");
    }
}