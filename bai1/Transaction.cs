namespace bai1;


public class Transaction
{
    public const int TYPE_DEPOSIT_CHECKING = 1;
    public const int TYPE_WITHDRAW_CHECKING = 2;
    public const int TYPE_DEPOSIT_SAVINGS = 3;
    public const int TYPE_WITHDRAW_SAVINGS = 4;
    public int Type { get; set; }
    public double Amount { get; set; }
    public double InitialBalance { get; set; }
    public double FinalBalance { get; set; }

    public Transaction()
    {

    }

    public Transaction(int type, double amount, double initialBalance, double finalBalance)
    {
        Type = type;
        Amount = amount;
        InitialBalance = initialBalance;
        FinalBalance = finalBalance;
    }

    private string GetTransactionTypeString(int type)
    => type switch
    {
        TYPE_DEPOSIT_CHECKING => "Nạp tiền vãng lai",
        TYPE_WITHDRAW_CHECKING => "Nạp tiền vãng lai",
        TYPE_DEPOSIT_SAVINGS => "Nạp tiền vãng lai",
        TYPE_WITHDRAW_SAVINGS => "Nạp tiền vãng lai",
        _ => throw new Exception("Type chua dc dinh nghia")
    };


    public string GetTransactionSummary()
    => "Kiểu giao dịch: " + GetTransactionTypeString(this.Type) + ". " +
        "Số dư ban đầu: " + this.Amount + ". " +
        "Số tiền: " + this.Amount + ". " +
        "Số dư cuối: " + this.Amount + "."
        ;


}