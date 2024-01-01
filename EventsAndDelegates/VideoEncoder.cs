using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    #region CustomEventArgs
    public class EncoderEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
    #endregion
    public class VideoEncoder
    {
        //1-Define a Delegate
        //2-Define an event based on that delegate
        //3-Raise the Event
        public delegate void VideoEncodedEventHandler(object source, EncoderEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video____");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded!=null)
            {
                VideoEncoded(this, new EncoderEventArgs() { video= video }); //Custom Event Args
                //VideoEncoded(this,EventArgs.Empty);
            }
        }
    }
}
