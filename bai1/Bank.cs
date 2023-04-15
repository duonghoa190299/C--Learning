namespace bai1;
using System.IO;

public class Bank
{
    private List<Customer> CustomerList { get; set; } = new List<Customer>();

    public void ReadCustomerList(string InputStream)
    {

        using StreamReader reader = new StreamReader(InputStream);

        string line;
        Customer cus = new Customer();

        while ((line = reader.ReadLine()!) != null)
        {
            if (Char.IsLetter(line[0]))
            {
                cus = new Customer();

                int index = -1;

                foreach (char c in line)
                {
                    index++;
                    if (Char.IsDigit(c))
                    {
                        break;
                    }
                }

                long idNumber = long.Parse(line.Substring(index));

                string fullName = line.Substring(0, index - 1);

                cus.IdNumber = idNumber;
                cus.FullName = fullName;

                if (cus.IdNumber != 0)
                {
                    this.CustomerList.Add(cus);
                }
            }
            else if (Char.IsDigit(line[0]))
            {
                string[] arr = line.Split(" ");
                if (arr[1] == Account.CHECKING)
                {
                    CheckingAccount acc = new CheckingAccount(long.Parse(arr[0]), double.Parse(arr[2]));
                    cus.AccountList.Add(acc);
                }

                if (arr[1] == Account.SAVINGS)
                {
                    SavingsAccount acc = new SavingsAccount(long.Parse(arr[0]), double.Parse(arr[2]));
                    cus.AccountList.Add(acc);
                }

            }

        }

    }

    public string GetCustomersinfoByIdOrder()
    {
        string customersinfoByIdOrder = "";

        var sortedCustomerList = this.CustomerList.OrderBy(c => c.IdNumber).ToList();

        foreach (Customer cus in sortedCustomerList)
        {
            customersinfoByIdOrder += $"{cus.GetCustomerInfo()}\n";
        }
        return customersinfoByIdOrder;
    }

    public string GetCustomersinfoByNameOrder()
    {
        string customersinfoByNameOrder = "";

        var sortedCustomerList = this.CustomerList.OrderBy(c => GetConvertFullName(c.FullName)).ToList();

        foreach (Customer cus in sortedCustomerList)
        {
            customersinfoByNameOrder += $"{cus.GetCustomerInfo()}\n";
        }
        return customersinfoByNameOrder;
    }

    public string GetConvertFullName(string? fullName)
    {
        if (fullName != null)
        {
            string[] arr = fullName.Split(" ");
            int arrLength = arr.Length;
            string convertFullName = arr[arrLength - 1];
            for (int i = 0; i < arrLength - 1; i++)
            {
                convertFullName += $" {arr[i]}";
            }
            return convertFullName;
        }
        else
        {
            return "";
        }
    }
}