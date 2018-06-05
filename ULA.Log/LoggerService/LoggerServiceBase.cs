using System;
using NLog;

namespace ULA.Log.LoggerService
{
  public  class LoggerServiceBase
    {
        public void LogMessage(string message, Logger logger, string messageTypeString)
        {
            logger?.Trace($"[{DateTime.Now.ToString()}][{messageTypeString}] {message}");
        }
    }
}
