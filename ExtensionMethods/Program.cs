using System;
using System.Security.Cryptography.X509Certificates;
namespace ExtensionMethods
{
    class Program
	{
		public static void Main(string[] args)
		{
			List<Receipt> receipts = new List<Receipt>();
			receipts.Add(new Receipt() { ReceiptNumber = "123-456-789"});
			Receipt receipt = new Receipt();
			Console.WriteLine("Total Number of Receipts: " + receipt.GetReceiptsCount(receipts));
        }
	}
}