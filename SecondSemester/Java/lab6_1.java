import java.util.Scanner;
import static java.lang.Math.abs;

public class LR_6_1 {
    public static void main(String[] args) {
        double[] x;
        double s, k, R;
        boolean m5;
        int N;
        Scanner scan = new Scanner(System.in);
        System.out.print("N = ");
        N = scan.nextInt();
        s = 0;
        k = 0;
        m5 = false;
        x = new double[N];

        for (int i = 0; i < N; i++)
        {
            System.out.print("x(" + i + ")= ");
            x[i] = scan.nextInt();
        }

        System.out.print("R = ");
        R = scan.nextDouble();
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
            System.out.println("Ошибка.");
        }

        else
        {
            System.out.println("Среднее арифметическое: "  + (s / k));
        }

        for (int i = 0; i < N; i++)
        {
            if (x[i] % 5 == 0)
            {
                System.out.println("Индекс элемента массива, кратного пяти: " + i + ", элемент: " + x[i]);
                m5 = true;
            }
        }

        if (m5 == false)
        {
            System.out.println("Элементов массива, кратных пяти, не найдено.");
        }
    }
}