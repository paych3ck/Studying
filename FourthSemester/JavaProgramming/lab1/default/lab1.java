import java.util.Scanner;

public class lab1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int maxpriceT = 0;
        int maxpriceC = 0;
        boolean founded = false;

        Carrier Carriers[];
        int n = 12;
        Carriers = new Carrier[n];

        Carriers[0] = new Train("TGV", 100, 30, 5);
        Carriers[1] = new Train("Siemens Velaro", 250, 20, 10);
        Carriers[2] = new Train("Shinkansen", 450, 41, 11);
        Carriers[3] = new Train("Talgo", 100, 30, 6);
        Carriers[4] = new Train("Maglev", 250, 20, 7);
        Carriers[5] = new Train("Thalys", 350, 42, 12);
        Carriers[6] = new Car("Toyota", 210, 36, 202);
        Carriers[7] = new Car("Hyundai", 560, 6, 150);
        Carriers[8] = new Car("Land Rover", 75, 25, 142);
        Carriers[9] = new Car("Kia", 210, 36, 95);
        Carriers[10] = new Car("Ford", 660, 6, 110);
        Carriers[11] = new Car("Lada", 75, 25, 125);

        System.out.println("Обычный класс.");

        System.out.print("Введите объем груза: ");
        int inweight = scan.nextInt();
        scan.close();

        for (int i = 0; i < n; i++) {
            if (Carriers[i] instanceof Train) {
                if (inweight * Carriers[i].getPrice() >= maxpriceT) {
                    maxpriceT = inweight * Carriers[i].getPrice();
                }
            }

            else if (Carriers[i] instanceof Car) {
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
            System.out.println("Невозможно перевезти заданный объем груза.");
        }
    }
}