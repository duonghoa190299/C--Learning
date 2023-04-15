using System.Text;
using bai1;
Console.OutputEncoding = Encoding.UTF8;

Bank bank = new();
string filePath = @"D:\OneDrive\Desktop\Learning c# zero to hero\bai1\data.txt";

bank.ReadCustomerList(filePath);
Console.WriteLine(bank.GetCustomersinfoByIdOrder());
Console.WriteLine(bank.GetCustomersinfoByNameOrder());





