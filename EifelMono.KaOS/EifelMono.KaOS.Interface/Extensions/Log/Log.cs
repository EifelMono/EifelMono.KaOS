using System;
using System.Runtime.CompilerServices;

namespace EifelMono.KaOS.Extensions
{
    public static class Log
    {
        public static ILogProxy Proxy { get; set; } = new DebugLogProxy();

        public static void LogException(this Exception ex,
                                 LogExDetails logExDetails = null,
                                 [CallerMemberName] string callerMemberName = "",
                                 [CallerLineNumber] int callerLineNumber = -1,
                                 [CallerFilePath] string callerFilePath = "")
        {
            if (logExDetails == null)
                logExDetails = new LogExDetails();
            logExDetails.Type = LogType.Exception;
            logExDetails.Ex = ex;
            logExDetails.CallerMemberName = callerMemberName;
            logExDetails.CallerLineNumber = callerLineNumber;
            logExDetails.CallerFilePath = callerFilePath;
            Proxy.Log(logExDetails);
        }

        public static void HandleException(this Exception ex,
                                 LogExDetails logExDetails = null,
                                 [CallerMemberName] string callerMemberName = "",
                                 [CallerLineNumber] int callerLineNumber = -1,
                                 [CallerFilePath] string callerFilePath = "")
        {
            ex.LogException(logExDetails, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static void LogTrace(this string value,
                                 LogDetails logDetails = null,
                                 [CallerMemberName] string callerMemberName = "",
                                 [CallerLineNumber] int callerLineNumber = -1,
                                 [CallerFilePath] string callerFilePath = "")
        {
            if (logDetails == null)
                logDetails = new LogDetails();
            logDetails.Type = LogType.Trace;
            logDetails.Value = value;
            logDetails.CallerMemberName = callerMemberName;
            logDetails.CallerLineNumber = callerLineNumber;
            logDetails.CallerFilePath = callerFilePath;
            Proxy.Log(logDetails);
        }

        public static void LogInfo(this string value,
                               LogDetails logDetails = null,
                               [CallerMemberName] string callerMemberName = "",
                               [CallerLineNumber] int callerLineNumber = -1,
                               [CallerFilePath] string callerFilePath = "")
        {
            if (logDetails == null)
                logDetails = new LogDetails();
            logDetails.Type = LogType.Info;
            logDetails.Value = value;
            logDetails.CallerMemberName = callerMemberName;
            logDetails.CallerLineNumber = callerLineNumber;
            logDetails.CallerFilePath = callerFilePath;
            Proxy.Log(logDetails);
        }

        public static void LogError(this string value,
                          LogDetails logDetails = null,
                          [CallerMemberName] string callerMemberName = "",
                          [CallerLineNumber] int callerLineNumber = -1,
                          [CallerFilePath] string callerFilePath = "")
        {
            if (logDetails == null)
                logDetails = new LogDetails();
            logDetails.Type = LogType.Error;
            logDetails.Value = value;
            logDetails.CallerMemberName = callerMemberName;
            logDetails.CallerLineNumber = callerLineNumber;
            logDetails.CallerFilePath = callerFilePath;
            Proxy.Log(logDetails);
        }

        public static void LogWarning(this string value,
                               LogDetails logDetails = null,
                               [CallerMemberName] string callerMemberName = "",
                               [CallerLineNumber] int callerLineNumber = -1,
                               [CallerFilePath] string callerFilePath = "")
        {
            if (logDetails == null)
                logDetails = new LogDetails();
            logDetails.Type = LogType.Warning;
            logDetails.Value = value;
            logDetails.CallerMemberName = callerMemberName;
            logDetails.CallerLineNumber = callerLineNumber;
            logDetails.CallerFilePath = callerFilePath;
            Proxy.Log(logDetails);
        }

        public static void LogDebug(this string value,
                             LogDetails logDetails = null,
                             [CallerMemberName] string callerMemberName = "",
                             [CallerLineNumber] int callerLineNumber = -1,
                             [CallerFilePath] string callerFilePath = "")
        {
            if (logDetails == null)
                logDetails = new LogDetails();
            logDetails.Type = LogType.Debug;
            logDetails.Value = value;
            logDetails.CallerMemberName = callerMemberName;
            logDetails.CallerLineNumber = callerLineNumber;
            logDetails.CallerFilePath = callerFilePath;
            Proxy.Log(logDetails);
        }
    }
}
