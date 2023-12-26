using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path) {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, Message.Error.ToString());           
        }

        public void LogInfo(string message)
        {
            Log(message, Message.Info.ToString());
        }
        public void LogWarning(string message)
        {
            Log(message, Message.Warning.ToString());
        }
        public void Log(string message, string messageType)
        {
            using (var streamWrite = new StreamWriter(_path, true))
            {
                streamWrite.WriteLine(messageType +": " + message);
            }
        }
    }
}
