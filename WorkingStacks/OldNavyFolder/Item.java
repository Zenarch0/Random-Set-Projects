
public class Item {
	protected int id;
	protected String color;
	protected String size;
	protected double price;
	protected int amount;
	protected String department;
	
	public Item(int id, String color, String size, double price, int amount, String department) {
		this.id = id;
		this.color = color;
		this.size = size;
		this.price = price;
		this.amount = amount;
		this.department = department;
	}

	public int getId(int id) {
		return id;
	}

	public String getColor() {
		return color;
	}

	public String getSize() {
		return size;
	}

	public double getPrice() {
		return price;
	}

	public int getAmount() {
		return amount;
	}

	public String getDepartment() {
		return department;
	}

	public void setId(int id) {
		this.id = id;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public void setSize(String size) {
		this.size = size;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public void setAmount(int amount) {
		this.amount = amount;
	}

	public void setDepartment(String department) {
		this.department = department;
	}

	@Override
	public String toString() {
		return "Items [id=" + id + ", color=" + color + ", size=" + size + ", price=" + price + ", amount=" + amount
				+ ", department=" + department + "]";
	}
	
}