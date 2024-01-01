namespace EventsAndDelegates
{
    public class MailService
	{
        public void OnVideoEncoded(object source, EncoderEventArgs args)
        {
            Console.WriteLine("Mail Service: Sending An Email...." + args.video.Title);
        }
  //      public void OnVideoEncoded(object source, EventArgs args)
		//{
  //          Console.WriteLine("Mail Service: Sending An Email....");
  //      }
	}
}