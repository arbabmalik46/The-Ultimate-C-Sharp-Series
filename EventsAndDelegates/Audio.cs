using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Audio : EventArgs
    {
        public string Title { get; set; }
        public string Singer { get; set; }
        public string Album { get; set; }
    }
    public class AudioEventArgs : EventArgs
    {
        public Audio Audio { get; set; }
    }
}
