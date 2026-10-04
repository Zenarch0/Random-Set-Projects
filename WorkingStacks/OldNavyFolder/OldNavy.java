import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.*;

public class OldNavy {

	static Scanner sc = new Scanner(System.in);

	public static void main(String[] args) {

		boolean active = true; int pick=0;

		ArrayListStack<Item> gentleMen = new ArrayListStack<>();
		ArrayListStack<Item> gentleWomen = new ArrayListStack<>();
		ArrayListStack<Item> gentleKids = new ArrayListStack<>();
		ArrayListStack<Item> temp = new ArrayListStack<>();

		try (BufferedReader br = new BufferedReader(
				new FileReader("C:\\Users\\Camilo\\OneDrive\\Documents\\UAA\\CS\\WorkingStacks\\src\\Clothing.txt"))){

			String line;
			while((line = br.readLine()) != null) {
				String[] data = line.split(",");

				int id = Integer.parseInt(data[0].trim());
				String color = data[1].trim();
				String size = data[2].trim();
				double price = Double.parseDouble(data[3].trim());
				int amount = Integer.parseInt(data[4].trim());
				String dep = data[5].trim();

				Item tempo = new Item(id,color,size,price,amount,dep);

				temp.push(tempo);

				if(tempo.getDepartment().equals("Men")) {
					gentleMen.push(tempo);
				}
				if(tempo.getDepartment().equals("Women")) {
					gentleWomen.push(tempo);
				}
				if(tempo.getDepartment().equals("Kids")) {
					gentleKids.push(tempo);
				}
			}

		} catch(IOException E){ E.printStackTrace(); }		

				do{
					System.out.println("Welcome to Old Navy, press # for action:\n"
							+ "to find a specific item by id press: 1\n"
							+ "to print inventory press: 2\n"
							+ "to print total inventory cost press: 3\n"
							+ "to sell items press: 4\n"
							+ "to leave press: 5\n");
					System.out.print("choice: ");
					pick = sc.nextInt();
		
					switch(pick) {
					case 1 -> idFinder(temp);
					case 2 -> printInv(gentleMen, gentleWomen, gentleKids);
					case 3 -> System.out.printf("\nThe total inventory value is: $%.2f \n", totalValue(gentleMen, gentleWomen, gentleKids));
					case 4 -> sellItem(temp);
					case 5 -> active = false;
					default-> System.out.println("invalid choice");
					}
					System.out.println();
		
				}while(active);
				System.out.println("Please come again!");
	}
	
	public static void idFinder(ArrayListStack<Item> temp) {
		int i=0, idFind=0;

		System.out.print("Enter the item id: ");
		idFind = sc.nextInt();

		if(idFind > 0 && idFind < temp.size() +1) {
			while(!temp.isEmpty() && i < temp.size()) {
				Item tempo = temp.elements.get(i);
				if(tempo.id == idFind) {
					System.out.println("Found " + tempo.amount + " items at id=" + tempo.id);
					break;
				}
				i++;
			}
		}else {System.out.printf("id=%s does not exist", idFind);}
	}
	
	public static void printInv(ArrayListStack<Item> gentleMen, ArrayListStack<Item> gentleWomen, ArrayListStack<Item> gentleKids) {
		int i=0;
		while(!gentleMen.isEmpty() && i < gentleMen.size()) {
			System.out.println(gentleMen.elements.get(i));
			i++;
		}
		i=0;
		while(!gentleWomen.isEmpty() && i < gentleWomen.size()) {
			System.out.println(gentleWomen.elements.get(i));
			i++;
		}
		i=0;
		while(!gentleKids.isEmpty() && i < gentleKids.size()) {
			System.out.println(gentleKids.elements.get(i));
			i++;
		}
	}

	public static double totalValue(ArrayListStack<Item> gentleMen, ArrayListStack<Item> gentleWomen, ArrayListStack<Item> gentleKids) {
		int i=0; double total=0; 
		while(!gentleMen.isEmpty() && i < gentleMen.size()) {
			total += gentleMen.elements.get(i).price * gentleMen.elements.get(i).amount;
			i++;
		} 
		i=0;
		while(!gentleWomen.isEmpty() && i < gentleWomen.size()) {
			total += gentleWomen.elements.get(i).price * gentleWomen.elements.get(i).amount;
			i++;
		}
		i=0;
		while(!gentleKids.isEmpty() && i < gentleKids.size()) {
			total +=gentleKids.elements.get(i).price * gentleKids.elements.get(i).amount;
			i++;
		}
		return total;
	}

	public static void sellItem(ArrayListStack<Item> temp) {
		int i=0, idFind=0, buy=0;

		System.out.print("Enter the id of your item: ");
		idFind = sc.nextInt();
		
		if(idFind > 0 && idFind < temp.size() +1) {
			System.out.print("\nHow many will you buy: ");
			buy = sc.nextInt();

			while(!temp.isEmpty()) {
				Item tempo = temp.elements.get(i);

				if(tempo.id == idFind) {
					if(buy > 0 && buy <= tempo.amount && tempo.amount > 0) {
						tempo.setAmount(tempo.getAmount() - buy);
						System.out.println("you bought " + buy + " " + temp.elements.get(i) + ", Thanks for the money choom!");
						break;
					} 
					else {
						System.out.println("The store does not have that amount");
						break;
					}
				}
				i++;
			}
		} else {System.out.printf("id=%s is unavailable\n", idFind);}
	}

}