namespace bai1;

public abstract class Account
{
    public const string CHECKING = "CHECKING";
    public const string SAVINGS = "SAVINGS";
    public long AccountNumber { get; set; }
    public double Balance { get; set; }
    public List<Transaction> TransactionList { get; set; } = new List<Transaction>();

    public Account()
    {

    }

    public Account(long accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void DoWithdrawing(double withdrawAmount)
    {
        if (withdrawAmount < 0)
        {
            throw new InvalidFundingAmountException(withdrawAmount);
        }
        else if (withdrawAmount > Balance)
        {
            throw new InsufficentFundsException(withdrawAmount);
        }

        this.Balance -= withdrawAmount;


    }

    public void DoDepositing(double depositAmount)
    {
        if (depositAmount < 0)
        {
            throw new InvalidFundingAmountException(depositAmount);
        }

        this.Balance += depositAmount;

    }

    public abstract void Withdraw(double withdrawAmount);

    public abstract void Deposit(double depositAmount);

    public void AddTransaction(Transaction transaction)
    {
        if (transaction != null)
        {
            this.TransactionList.Add(transaction);
        }
    }

    public string GetTransactionHistory()
    {
        string transactionHistory = "Lịch sủ giao dịch của tài khoản " + this.AccountNumber + ": \n";

        foreach (Transaction tran in this.TransactionList)
        {
            transactionHistory += tran.GetTransactionSummary() + "\n";
        }

        return transactionHistory;
    }

    public override bool Equals(Object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Account other = (Account)obj;
        return this.AccountNumber == other.AccountNumber && this.Balance == other.Balance;
    }
}