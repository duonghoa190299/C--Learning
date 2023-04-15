namespace bai1;


public class Customer
{
    public long IdNumber { get; set; }
    public string? FullName { get; set; }
    public List<Account> AccountList { get; set; } = new List<Account>();

    public Customer()
    {

    }

    public Customer(long idNumber, string fullName)
    {
        IdNumber = idNumber;
        FullName = fullName;
    }

    public string GetCustomerInfo()
    {
        string customerInfo = "Số CMND: " + this.IdNumber + "  Họ và tên: " + this.FullName;
        return customerInfo;
    }

    public void AddAccount(Account account)
    {
        this.AccountList.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        this.AccountList.Remove(account);
    }

}