namespace bai1;

public class CheckingAccount : Account
{

    public CheckingAccount()
    {
    }

    public CheckingAccount(long accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public override void Deposit(double depositAmount)
    {
        try{
            base.DoDepositing(depositAmount);
        }
        catch(InvalidFundingAmountException e) {
            Console.WriteLine(e.Message);
        }
    }

    public override void Withdraw(double withdrawAmount)
    {
        try{
            base.DoWithdrawing(withdrawAmount);
        }
        catch(InvalidFundingAmountException e1) {
            Console.WriteLine(e1.Message);
        }
        catch(InsufficentFundsException e2) {
            Console.WriteLine(e2.Message);
        }
    }
}