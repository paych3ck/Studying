class Train extends Carrier {
    private int rides;

    public Train(String name, int weight, int price, int rides) {
        super(name, weight, price);
        this.rides = rides;
    }

    public int getRides() {
        return this.rides;
    }

    public void setRides(int rides) {
        this.rides = rides;
    }

    public String getInfo() {
        return "Марка поезда: " + getName() + "\nМаксимально возможный вес груза: " + getWeight() + "кг." + "\nЦена за КГ груза: " + getPrice() + "\nКоличество вагонов: " + getRides();
    }
}