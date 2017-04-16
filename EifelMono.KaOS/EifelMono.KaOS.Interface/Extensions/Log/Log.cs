using System;
using System.Runtime.CompilerServices;

namespace EifelMono.KaOS.Extensions
{
    public static partial class Log
    {
        public static ILogProxy Proxy { get; set; } = new DebugLogProxy();

        public static void LogException(this Exception ex,
                                 ExDetails exDetails = null,
                                 [CallerMemberName] string callerMemberName = "",
                                 [CallerLineNumber] int callerLineNumber = -1,
                                 [CallerFilePath] string callerFilePath = "")
        {
            if (exDetails == null)
                exDetails = new ExDetails();
            exDetails.Type = Type.Exception;
            exDetails.Message = ex.ToString();
            exDetails.Ex = ex;
            exDetails.CallerMemberName = callerMemberName;
            exDetails.CallerLineNumber = callerLineNumber;
            exDetails.CallerFilePath = callerFilePath;
            Proxy.Log(exDetails);
        }

        public static void HandleException(this Exception ex,
                                 ExDetails exDetails = null,
                                 [CallerMemberName] string callerMemberName = "",
                                 [CallerLineNumber] int callerLineNumber = -1,
                                 [CallerFilePath] string callerFilePath = "")
        {
            ex.LogException(exDetails, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static void LogTrace(this string value,
                                 Details details = null,
                                 [CallerMemberName] string callerMemberName = "",
                                 [CallerLineNumber] int callerLineNumber = -1,
                                 [CallerFilePath] string callerFilePath = "")
        {
            if (details == null)
                details = new Details();
            details.Type = Type.Trace;
            details.Message = value;
            details.CallerMemberName = callerMemberName;
            details.CallerLineNumber = callerLineNumber;
            details.CallerFilePath = callerFilePath;
            Proxy.Log(details);
        }

        public static void LogInfo(this string message,
                               Details details = null,
                               [CallerMemberName] string callerMemberName = "",
                               [CallerLineNumber] int callerLineNumber = -1,
                               [CallerFilePath] string callerFilePath = "")
        {
            if (details == null)
                details = new Details();
            details.Type = Type.Info;
            details.Message = message;
            details.CallerMemberName = callerMemberName;
            details.CallerLineNumber = callerLineNumber;
            details.CallerFilePath = callerFilePath;
            Proxy.Log(details);
        }

        public static void LogError(this string value,
                                    Details details = null,
                          [CallerMemberName] string callerMemberName = "",
                          [CallerLineNumber] int callerLineNumber = -1,
                          [CallerFilePath] string callerFilePath = "")
        {
            if (details == null)
                details = new Details();
            details.Type = Type.Error;
            details.Message = value;
            details.CallerMemberName = callerMemberName;
            details.CallerLineNumber = callerLineNumber;
            details.CallerFilePath = callerFilePath;
            Proxy.Log(details);
        }

        public static void LogWarning(this string value,
                               Details details = null,
                               [CallerMemberName] string callerMemberName = "",
                               [CallerLineNumber] int callerLineNumber = -1,
                               [CallerFilePath] string callerFilePath = "")
        {
            if (details == null)
                details = new Details();
            details.Type = Type.Warning;
            details.Message = value;
            details.CallerMemberName = callerMemberName;
            details.CallerLineNumber = callerLineNumber;
            details.CallerFilePath = callerFilePath;
            Proxy.Log(details);
        }

        public static void LogDebug(this string value,
                             Details details = null,
                             [CallerMemberName] string callerMemberName = "",
                             [CallerLineNumber] int callerLineNumber = -1,
                             [CallerFilePath] string callerFilePath = "")
        {
            if (details == null)
                details = new Details();
            details.Type = Type.Debug;
            details.Message = value;
            details.CallerMemberName = callerMemberName;
            details.CallerLineNumber = callerLineNumber;
            details.CallerFilePath = callerFilePath;
            Proxy.Log(details);
        }
    }
}
