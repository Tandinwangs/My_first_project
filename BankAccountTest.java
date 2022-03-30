import java.util.Scanner;

class BankAccount{
	int BALANCE = 500;
	
	int Deposit_Money(int amount){
		 BALANCE = BALANCE + amount;
		return BALANCE;
	}
	int Withdraw_Money(int amount){
		 BALANCE = BALANCE - amount;
		return BALANCE;
 
	}
	int Check_Balance (){
		return BALANCE;
	}
}
class BankAccountTest{
	public static void main(String [] args){
		Scanner sc = new Scanner(System.in);
		BankAccount nu = new BankAccount();
		int amount;
		int choi;
		int current_Bal;

		do {
			System.out.println("**** MENU ****");
			System.out.println("1. Deposit Money");
			System.out.println("2. Withdraw Money");
			System.out.println("3. Check Balance");
			System.out.println("4. Exit");


			System.out.println("Enter your choice: ");
			choi = sc.nextInt();

			if (choi == 1){
				System.out.println("[DEPOSIT] Enter the Amount: " );
				amount = sc.nextInt();
				nu.Deposit_Money(amount);

			}else if (choi == 2){
				System.out.println("[WITHDRAW] Enter the Amount: ");
				amount = sc.nextInt();
				current_Bal = nu.Check_Balance(); 
				if (current_Bal < amount ){
					System.out.println("Insufficient money for Withdrawl!");
				}else{
					System.out.println("The amount of money Withdrew is: "+ amount);
					nu.Withdraw_Money(amount);
				}
				

			}else if (choi == 3){
				current_Bal = nu.Check_Balance();
				System.out.println("[BALANCE] The current balance is: "+ current_Bal);

			}

		}while (choi != 4);
			System.out.println("Thank you for using our service.");
		
	}
}