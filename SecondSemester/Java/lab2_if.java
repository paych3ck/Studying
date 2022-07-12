import static java.lang.Math.sqrt;
import java.util.Scanner;

class lab2_if {
    public static void main(String[] args) {
        double local_max, local_min, x1, x2, x3, x4, x5, y, a, b;
        Scanner scan = new Scanner(System.in);
        System.out.print("x1 = "); 
        x1 = scan.nextDouble();
        System.out.print("x2 = "); 
        x2 = scan.nextDouble();
        System.out.print("x3 = "); 
        x3 = scan.nextDouble();
        System.out.print("x4 = ");
        x4 = scan.nextDouble();
        System.out.print("x5 = ");
        x5 = scan.nextDouble();
        scan.close();

        local_max = x1;

        if (x2 > local_max)
        {
            local_max = x2;
        }

        a = x3;

        if (local_max < a)
        {
            a = local_max;
        }

        if (x4 < a) 
        {
            a = x4;
        }

        if (x5 < a)
        {
            a = x5;
        }

        local_min = x3;

        if (x4 < local_min)
        {
            local_min = x4;
        }

        b = x1;

        if (x2 > b)
        {
            b = x2;
        }

        if (local_min > b)
        {
            b = local_min;
        }

        if (x5 > b)
        {
            b = x5;
        }

        if (((3 * a + 4 * b) / (2 * b + a) < 0) || (2 * b + a == 0))
        {
            System.out.println("Error.");
        }

        else
        {
            y = sqrt((3 * a + 4 * b) / (2 * b + a));
            System.out.println("y = " + y);

        }        
    }
}