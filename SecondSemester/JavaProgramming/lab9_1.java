import java.util.Scanner;
import java.util.Arrays;
import static java.lang.Math.abs;

public class a_lab9_1 {
    public static String absR(int N, double R) {
        double[] x;
        double s, k;
        Scanner scan = new Scanner(System.in);
        System.out.println("N = " + N);
        System.out.println("R = " + R);
        s = 0;
        k = 0;
        x = new double[N];

        for (int i = 0; i < N; i++)
        {
            System.out.print("x(" + i + ")= ");
            x[i] = scan.nextDouble();
        }

        scan.close();

        for (int i = 0; i < N; i++)
        {
            if (abs(x[i]) < R)
            {
                s += x[i];
                k += 1;
            }
        }

        if (k == 0)
        {
            return "Ошибка.";
        }

        else
        {
            return "Среднее арифметическое: "  + (s / k);
        }
    }
    public static void main(String[] args) {
        System.out.println(absR(11, 4));
    }
}