import java.util.Scanner;

public class a_lab8_1 {
    public static void main(String[] args) {
        String S;
        Scanner scan = new Scanner(System.in);
        System.out.print("S = ");
        S = scan.nextLine();
        scan.close();

        for (int i = 0; i < 10; i++)
        {
            S = S.replace(Integer.toString(i), "");
        }
        System.out.println(S);
    }
}