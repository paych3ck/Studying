public class Carrier {
	String type;
	String name;
	int weight;
	int priceperkg;
	Boolean isCarriage;

	public Carrier(String type, String name, int weight, int priceperkg, Boolean isCarriage) {
		this.type = type;
		this.name = name;
		this.weight = weight;
		this.priceperkg = priceperkg;
		this.isCarriage = isCarriage;
	}

	public String getType() {
		return type;
	}

	public String getName() {
		return name;
	}

	public int getWeight() {
		return weight;
	}

	public int getPriceperkg() {
		return priceperkg;
	}

	public Boolean getIsCarriage() {
		return isCarriage; 
	}
}