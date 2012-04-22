using System;

namespace SportsStore.WebUI.Infrastructure.Logging
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogDebug(string message);
        void LogError(string message);
        void LogError(Exception x);
        void LogFatal(string message);
        void LogFatal(Exception x);
    }
}