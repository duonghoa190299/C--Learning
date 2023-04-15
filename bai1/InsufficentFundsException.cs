namespace bai1;

public class InsufficentFundsException : BankException
{
    public InsufficentFundsException(double balance) : base($"Số dư tài khoản không đủ {balance} để thực hiện giao dịch") { }
     
}