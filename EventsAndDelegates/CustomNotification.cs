using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class CustomNotification
    {
        public void OnAudioEncoderInitialized(object source, AudioEventArgs eventArgs)
        {
            Console.WriteLine("Custom Notification: {0} has been Encoded",eventArgs.Audio.Title);
        }
    }
}
