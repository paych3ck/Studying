import static java.lang.Math.abs;
import static java.lang.Math.pow;
import static java.lang.Math.sqrt;

import java.util.Scanner;

class lab2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
		System.out.print("x: ");   
        double x = scan.nextDouble();
        System.out.print("y: ");
        double y = scan.nextDouble();
        scan.close();
        double a = 0;
        double b = 0;
        
        b = (sqrt(abs(x + y))) / pow(x, abs(y - 2));
        a = x > y ? b + pow(x, 2) : pow(y, 2) - b;

        System.out.println("a: " + a + " b: " + b);
    }
}