class TrainI extends CarrierIr {
    private int rides;

    public TrainI(String name, int weight, int price_per_kg, int rides) {
        super(name, weight, price_per_kg);
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