class CarA extends CarrierA {
    private int horsepower;

    public CarA(String name, int weight, int power, int horsepower) {
        super(name, weight, power);
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