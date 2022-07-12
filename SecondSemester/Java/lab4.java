import java.util.Scanner;

public class LR_4 {
    public static void main(String[] args) {
        int k;
        double x, E, S, y, R, x2;
        Scanner inp = new Scanner(System.in);
        System.out.print("x = ");
        x = inp.nextDouble();
        System.out.print("E = "); 
        E = inp.nextDouble();
        inp.close();
        R = Math.pow(x, 3);
        S = ((2 * x - 1) * R) / 6;
        k = 1;
        x2 = Math.pow(x, 2);

        do 
        {
            k++;
            R = R * x2;
            S = S + R * ((2 * k * x - 1) / (2 * k * (2 * k + 1)));
        } 
        while ((Math.abs(R / S) > E) && (k < 1000));

        if (k == 1000) 
        {
            System.out.println("Ошибка.");
        }
        
        else 
        {
            y = Math.log((Math.pow(1 + x, x + 1.0 / 2)) / Math.sqrt(1 - x)) - Math.pow(x, 2) - x;
            System.out.printf("S = %1.8f\ny = %1.8f\nE = %1.8f\nk = %d", S, y, Math.abs(S - y), k);
        }
    }
}