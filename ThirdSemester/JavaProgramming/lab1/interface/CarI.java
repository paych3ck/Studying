class CarI extends CarrierIr {
    private int horsepower;

    public CarI(String name, int weight, int price_per_kg, int horsepower) {
        super(name, weight, price_per_kg);
        this.horsepower = horsepower;
    }

    public int getHorsepower() {
        return this.horsepower;
    }

    public void setHorsepower(int horsepower) {
        this.horsepower = horsepower;
    }

    public String getInfo() {
        return "Марка машины: " + getName() + "\nМаксимально возможный вес груза: " + getWeight() + "кг." + "\nЦена за КГ груза: " + getPrice() + "\nЛошадиных сил: " + getHorsepower();
    }
}