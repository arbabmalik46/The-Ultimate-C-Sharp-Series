using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class AudioEncoder
    {
        public event EventHandler<AudioEventArgs> AudioEncoderInitialized;

        public void Encode(Audio audio)
        {
            //logic
            Console.WriteLine("Encoding Audio____");
            Thread.Sleep(4000);
            //Call the Event Handler Method
            OnAudioEncoderInitialized(audio);
        }
        /// <summary>
        /// This is a event handler method
        /// </summary>
        public virtual void OnAudioEncoderInitialized(Audio audio)
        {
            if (AudioEncoderInitialized != null)
            {
                AudioEncoderInitialized(this, new AudioEventArgs() { Audio = audio});
            }
        }
    }
}
