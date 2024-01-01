namespace ExtensionMethods
{
    public static class ReceiptExtension
	{
		public static int GetReceiptsCount(this Receipt receipt, List<Receipt> receipts)
		{
			return receipts.Count;
		}
	}
}