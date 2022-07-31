import java.util.Scanner;

public class lab1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int maxpriceT = 0;
        int maxpriceC = 0;
        boolean founded = false;

        CarrierI Carriers[];
        int n = 12;
        Carriers = new CarrierI[n];

        Carriers[0] = new TrainI("TGV", 100, 30, 5);
        Carriers[1] = new TrainI("Siemens Velaro", 250, 20, 10);
        Carriers[2] = new TrainI("Shinkansen", 450, 41, 11);
        Carriers[3] = new TrainI("Talgo", 100, 30, 6);
        Carriers[4] = new TrainI("Maglev", 250, 20, 7);
        Carriers[5] = new TrainI("Thalys", 350, 42, 12);
        Carriers[6] = new CarI("Toyota", 210, 36, 202);
        Carriers[7] = new CarI("Hyundai", 560, 6, 150);
        Carriers[8] = new CarI("Land Rover", 75, 25, 142);
        Carriers[9] = new CarI("Kia", 210, 36, 95);
        Carriers[10] = new CarI("Ford", 660, 6, 110);
        Carriers[11] = new CarI("Lada", 75, 25, 125);

        System.out.println("Интерфейс.");

        System.out.print("Введите объем груза: ");
        int inweight = scan.nextInt();
        scan.close();

        for (int i = 0; i < n; i++) {
            if (Carriers[i] instanceof TrainI) {
                if (inweight * Carriers[i].getPrice() >= maxpriceT) {
                    maxpriceT = inweight * Carriers[i].getPrice();
                }
            }

            else if (Carriers[i] instanceof CarI) {
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
                founded = true;
                System.out.println("Тип: " + Carriers[i].getClass().getSimpleName() + "\n" + Carriers[i].getInfo());
                System.out.println();
            }
        }

        if (!founded)
        {
            System.out.println("Не найдено автобусов заданного вида.");
        }
    }
}