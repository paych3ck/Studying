import java.util.Scanner;

public class Andrey {
	public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String str, zamena, S;
        zamena = "";
        S = "";
        System.out.print("Введите строку: ");
        str = scan.nextLine();
        scan.close();
        String [] strArray = str.split(" ");
        zamena = strArray[strArray.length - 1];
        strArray[strArray.length - 1] = strArray[strArray.length - 2];
        strArray[strArray.length - 2] = zamena;

        for (int i = 0; i < strArray.length; i++)
        {
            S = S + strArray[i] + " ";
        }
        System.out.println(S);
    }
}