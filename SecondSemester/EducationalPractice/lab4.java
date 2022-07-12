import java.util.Scanner;
import java.util.Arrays;

public class lab4 {
    public static void main(String[] args) {
        double[] x;
        double s, C, D;
        int N, newN, k1, k2;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        System.out.print("C = ");
        C = scan.nextInt();
        System.out.print("D = ");
        D = scan.nextInt();
        newN = 0;
        k1 = 0;
        k2 = 0;
        s = 0;

        x = new double[N];
        
        for (int i = 0; i < N; i++)
        {
            System.out.print("x(" + i + ") = ");
            x[i] = scan.nextDouble();
        }

        scan.close();

        for (int i = 0; i < N; i++)
        {
            if (x[i] < 0 && i % 2 == 0)
            {
                k1 += 1;
            }

            if (C <= x[i] && x[i] <= D)
            {
                k2 += 1;
                s += x[i];
            }
        }

        for (int i = 0; i < N; i++)
        {
            System.out.printf("x(%d) = %1.2f\n", i, x[i]);
        }

        System.out.println("Количество элементов: " + k1);
        System.out.println("Среднее арифметическое: " + s / k2);

        for (int i = 0; i < N; i++)
        {
            if (x[i] % 1 != 0)
            {
                x[newN] = x[i];
                newN++;
            }
        }
        
        x = Arrays.copyOf(x, newN);

        for (int i = 0; i < newN; i++)
        {
            System.out.printf("x(%d) = %1.2f\n", i, x[i]);
        }
    }
}