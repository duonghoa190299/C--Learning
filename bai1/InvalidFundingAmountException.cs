namespace bai1;


public class InvalidFundingAmountException : BankException
{
    public InvalidFundingAmountException(double balance) : base($"số tiền không hợp lệ: ${balance}")
    {
    }
}