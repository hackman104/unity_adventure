using System;
using UnityEngine;

namespace Atalanta.Services
{
    public class UnityLogger : RSG.Utils.ILogger
    {
        public void LogError(Exception ex, string message, params object[] args)
        {
            Debug.LogError(message + "\r\nException:\r\n" + ex.ToString());
        }

        public void LogError(string message, params object[] args)
        {
            Debug.LogError(message);
        }

        public void LogInfo(string message, params object[] args)
        {
            Debug.Log(message);
        }

        public void LogVerbose(string message, params object[] args)
        {
            Debug.Log(message);
        }

        public void LogWarning(string message, params object[] args)
        {
            Debug.LogWarning(message);
        }
    }
}