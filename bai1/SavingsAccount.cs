namespace bai1;

public class SavingsAccount : Account
{

    public SavingsAccount() { }

    public SavingsAccount(long accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public override void Deposit(double depositAmount)
    {
        try
        {
            base.DoDepositing(depositAmount);
        }
        catch (InvalidFundingAmountException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public override void Withdraw(double withdrawAmount)
    {
        if (withdrawAmount > 1000)
        {
            Console.WriteLine("số tiền rút ra của tài khoản tiết kiệm phải nhỏ hơn $1000");
        }
        else if (this.Balance < 5000)
        {
            Console.WriteLine("số dư tài khoản tiết kiệm phải có ít nhất $5000");
        }
        else
        {
            try
            {
                base.DoWithdrawing(withdrawAmount);
            }
            catch (InvalidFundingAmountException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (InsufficentFundsException e2)
            {
                Console.WriteLine(e2.Message);
            }
        }

    }
}