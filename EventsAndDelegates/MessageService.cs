using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MessageService
    {
        //public void OnVideoEncoded(object source, EventArgs args)
        //{
        //    Console.WriteLine("Message Service: Sending Message....");
        //}
        public void OnVideoEncoded(object source, EncoderEventArgs args)
        {
            Console.WriteLine("Mail Service: Sending An Email.... " + args.video.Title);
        }
    }
}
