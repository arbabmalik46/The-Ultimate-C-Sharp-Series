using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class NotificationService
    {
        public void OnAudioEncoderInitialized(object source, AudioEventArgs args)
        {
            Console.WriteLine("Pop-Up Notification: {0} has been encoded", args.Audio.Title);
        }
    }
}
