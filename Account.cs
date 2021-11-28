class Account{
    int balance = 5000;
    
    public int withdraw(int amount){
        if(balance >= amount){
            balance -= amount;
            return amount;
        }else{
            return 0;
        }
    }

    public int getBalance(){
        return balance;
    }

}