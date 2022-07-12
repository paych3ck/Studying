import static java.lang.Math.sin;
import static java.lang.Math.cos;
import static java.lang.Math.tan;
import static java.lang.Math.pow;
import static java.lang.Math.abs;
import static java.lang.Math.sqrt;

import java.util.Scanner;

class lab1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
		System.out.print("x: ");   
		double x = scan.nextDouble();
		System.out.print("y: ");   
		double y = scan.nextDouble();
		double result;

        result = ((pow(y, x)) / (sqrt(pow(x, 2) + 4 * y + 1))) + sin((x + y) / (2 * x + 4)) + pow(4 * y, 1.0 / 3);

        System.out.println(result);
    }
}