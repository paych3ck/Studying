import java.util.Scanner;

public class lab1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int maxpriceT = 0;
        int maxpriceC = 0;
        boolean transportability = false;

        CarrierA Carriers[];
        int n = 12;
        Carriers = new CarrierA[n];

        Carriers[0] = new TrainA("TGV", 100, 30, 5);
        Carriers[1] = new TrainA("Siemens Velaro", 250, 20, 10);
        Carriers[2] = new TrainA("Shinkansen", 450, 41, 11);
        Carriers[3] = new TrainA("Talgo", 100, 30, 6);
        Carriers[4] = new TrainA("Maglev", 250, 20, 7);
        Carriers[5] = new TrainA("Thalys", 350, 42, 12);
        Carriers[6] = new CarA("Toyota", 210, 36, 202);
        Carriers[7] = new CarA("Hyundai", 560, 6, 150);
        Carriers[8] = new CarA("Land Rover", 75, 25, 142);
        Carriers[9] = new CarA("Kia", 210, 36, 95);
        Carriers[10] = new CarA("Ford", 660, 6, 110);
        Carriers[11] = new CarA("Lada", 75, 25, 125);

        System.out.println("Абстрактный класс.");

        System.out.print("Введите объем груза: ");
        int inweight = scan.nextInt();
        scan.close();

        for (int i = 0; i < n; i++) {
            if (Carriers[i] instanceof TrainA) {
                if (inweight * Carriers[i].getPrice() >= maxpriceT) {
                    maxpriceT = inweight * Carriers[i].getPrice();
                }
            }

            else if (Carriers[i] instanceof CarA) {
                if (inweight * Carriers[i].getPrice() >= maxpriceC) {
                    maxpriceC = inweight * Carriers[i].getPrice();
                }
            }
        }

        System.out.println("Максимальная стоимость перевозки перевозки заданного объема груза для машины: " + maxpriceC);
        System.out.println("Максимальная стоимость перевозки перевозки заданного объема груза для поезда: " + maxpriceT);
        System.out.println();

        for (int i = 0; i < n; i++)
        {
            if (Carriers[i].getWeight() >= inweight)
            {
                transportability = true;
                System.out.println("Тип: " + Carriers[i].getClass().getSimpleName() + "\n" + Carriers[i].getInfo());
                System.out.println();
            }
        }

        if (!transportability) 
        {
            System.out.println("Невозможно перевезти заданный объем груза.");
        }
    }
}