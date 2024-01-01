namespace ExtensionMethods
{
    public class Receipt
	{
		public Receipt()
		{
			ReceiptNumber = String.Empty;
		}
		public string ReceiptNumber { get; set; }
		public void GetReceipts()
		{
			ReceiptNumber = "100-223-123";
		}
	}
}