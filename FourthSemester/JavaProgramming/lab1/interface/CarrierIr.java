class CarrierIr implements CarrierI {
    private String name;
    private int weight;
    private int price_per_kg;

    public CarrierIr(String name, int weight, int price_per_kg) {
        this.name = name;
        this.weight = weight;
        this.price_per_kg = price_per_kg;
    }

    public String getName() {
        return this.name;
    }

    public int getWeight() {
        return this.weight;
    }

    public int getPrice() {
        return this.price_per_kg;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public void setPrice(int price_per_kg) {
        this.price_per_kg = price_per_kg;
    }

    @Override
    public String getInfo() {
        return "Марка ТС: " + getName() + "\nМаксимально возможный вес груза: " + getWeight() + "кг." + "\nЦена за КГ груза: " + getPrice();
    }
}