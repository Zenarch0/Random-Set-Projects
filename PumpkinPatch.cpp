#include<iostream>
#include<string>
#include<fstream>
using namespace std;

//Calculates avarage price of user's pumpkins
double Calc_Avg(double total, double pumpkins);

//Finds user's smollest pumpkin
double Smoll_Pum(double pumpkins, double weight[]);

//Finds user's beegest pumpkin
double Beeg_Pum(double pumpkins, double weight[]);

//Calculate user's total iventory value
double Inventory_total(double total);

//User's Pumpkin Patch
int main() {
	char awn;
	do {
		double price = 0, pumpkins = 0, weight[20], total = 0;

		//load any existing user data
		ifstream Load("Pumpkin_Info.txt");
		if (Load.is_open()) {
			Load >> price;
			Load >> pumpkins;
			for (int w = 0; w < pumpkins; w++) {
				Load >> weight[w];
			}
			Load.close();
			cout << "||Loaded your previous data||\n";
		}
		else {
			cout << "\n||No previous data||\n";
		}
		//set their total if data exists
		for (int t = 0; t < pumpkins; t++) {
			total += weight[t] * price;
		}

		int choice;
		do {
			cout << "||------------------------------------------------------------||\n";
			cout << "||Welcome to FarmVille where you have a personal pumpkin patch||\n";
			cout << "||------------------------------------------------------------||\n||";

			cout << "\n||To set the price of your pumpkins |press (1)|";
			cout << "\n||To enter an amount of pumpkins    |press (2)|";
			cout << "\n||To display pumpkin details        |press (3)|";
			cout << "\n||To calculate avarage pumpkin price|press (4)|";
			cout << "\n||To find your smallest pumpkin     |press (5)|";
			cout << "\n||To find your biggest pumpkin      |press (6)|";
			cout << "\n||To calculate your inventory value |press (7)|";
			cout << "\n||To exit                           |press (8)|";

			cout << "\n||\n||Enter your choice: ";
			cin >> choice;

			switch (choice) {
			case 1:
				cout << "||\n||How much do the pumpkins cost(per pound): $";
				cin >> price;
				break;
			case 2:
				cout << "||\n||How many pumpkins do you want to add(max 20): ";
				cin >> pumpkins;
				for (int i = 0; i < pumpkins; i++) {
					cout << "||\n||How much does pumpkin #" << i + 1 << " weigh(pounds): ";
					cin >> weight[i];
				}
				break;
			case 3:
				if(price != 0){
					for (int i = 0; i < pumpkins; i++) {
						total += weight[i] * price;
						cout << "||\n||Pumpkin #" << i + 1 << " weighs: " << weight[i] << " pounds" << " and costs: $" << weight[i] * price << '\n';
					}
				}
				else {
					cout << "||\n||*You must set a price before using this function*\n";
				}
				break;
			case 4:
				if (pumpkins != 0) {
					cout << "||\n||Your pumpkins are worth $" << Calc_Avg(total, pumpkins) << " on avarage\n";
				}
				else {
					cout << "||\n||*You do not have any pumpkins*\n";
				}
				break;
			case 5:
				if (pumpkins != 0) {
					cout << "||\n||Your smallest pumpkin weighs " << Smoll_Pum(pumpkins, weight) << " pounds\n";
				}
				else {
					cout << "||\n||*You do not have any pumpkins*\n";
				}
				break;
			case 6:
				if (pumpkins != 0) {
					cout << "||\n||Your biggest pumpkin weighs " << Beeg_Pum(pumpkins, weight) << " pounds\n";
				}
				else {
					cout << "||\n||*You do not have any pumpkins*\n";
				}
				break;
			case 7:
				if (pumpkins != 0) {
					cout << "||\n||The total worth of your pumpkins is $" << Inventory_total(total) << '\n';
				}
				else {
					cout << "||\n||*You do not have any pumpkins*\n";
				}
				break;
			case 8:
				break;
			}
		} while (choice != 8);

		ofstream Data("Pumpkin_Info.txt");

		if (Data.is_open()) {//had Chatgpt help with the Data
			Data << price << '\n';
			Data << pumpkins << '\n';
			for (int d = 0; d < pumpkins; d++) {
				Data << weight[d] << ' ';
			}
		}
		else {
			cout << "Error";
			return 1;
		}
		Data.close();

		cout << "\n\n|*|This was a nice way to kill time knowing everyone else will suffer :D|*|";

		cout << "\n\nRerun program(Y/N): ";
		cin >> awn;
	} while (awn == 'Y' || awn == 'y');
	return 0;
}
double Calc_Avg(double total, double pumpkins) {
	return total / pumpkins;
}

double Smoll_Pum(double pumpkins, double weight[]) {
	double min = weight[0];

	for (int s = 0; s < pumpkins; s++) {
		if (weight[s] < min) {
			min = weight[s];
		}
	}
	return min;
}

double Beeg_Pum(double pumpkins, double weight[]) {
	double max = weight[0];

	for (int b = 0; b < pumpkins; b++) {
		if (weight[b] > max) {
			max = weight[b];
		}
	}
	return max;
}
double Inventory_total(double total) {
	return total;
}