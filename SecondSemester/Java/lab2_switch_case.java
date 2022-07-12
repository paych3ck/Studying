import static java.lang.Math.sin;
import static java.lang.Math.pow;
import static java.lang.Math.sqrt;

import java.util.Scanner;

class LR2_switch_case {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
		System.out.print("a: ");   
        double a = scan.nextDouble();
        scan.close();
        double y = 0;

        switch (a <= -10 || 1 <= a && a <= 8 ? 1 : 0) {
            case 1: {
                y = 1 - pow(a, 2);
              break;
            }
            case 0: {
              switch (16 <= a && a <= 40 || a == 59 || a == 65 ? 1 : 0) {
                case 1: {
                  y = sqrt(pow(a, 3) - 2) + 15;
                  break;
                }
                case 0: {
                  switch (-8 <= a && a <= -2 || a == 50 || a == 60 || a >= 70 ? 1 : 0) {
                    case 1: {
                        y = sin(a - 3);
                      break;
                    }
                    case 0: {
                        y = a - 10;
                      break;
                    }
                  }
                }
              }
            }
          }
        System.out.println("y: " + y);
    }
}