using System;
using System.Runtime.CompilerServices;

namespace EifelMono.KaOS.Extensions
{
    public static partial class Log
    {
        public static ILogProxy Proxy { get; set; } = new DebugLogProxy();

        private static Detail ProxyLog(Detail detail,
                                       Detail parentDetail,
                                       string message,
                                       string kind,
                                       string callerMemberName,
                                       int callerLineNumber,
                                       string callerFilePath)
        {
            if (detail == null)
                detail = new Detail();
            if (parentDetail != null)
                detail.ParentId = parentDetail.Id;
            detail.Kind = kind;
            detail.Message = message;
            detail.CallerMemberName = callerMemberName;
            detail.CallerLineNumber = callerLineNumber;
            detail.CallerFilePath = callerFilePath;
            Proxy?.Log(detail);
            return detail;
        }

        public static Detail LogTrace(this string message,
                                      Detail parentDetail = null,
                                      [CallerMemberName] string callerMemberName = "",
                                      [CallerLineNumber] int callerLineNumber = -1,
                                      [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Trace, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static Detail LogInfo(this string message,
                                     Detail parentDetail = null,
                                     [CallerMemberName] string callerMemberName = "",
                                     [CallerLineNumber] int callerLineNumber = -1,
                                     [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Info, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static Detail LogError(this string message,
                                      Detail parentDetail = null,
                                      [CallerMemberName] string callerMemberName = "",
                                      [CallerLineNumber] int callerLineNumber = -1,
                                      [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Error, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static Detail LogWarning(this string message,
                                        Detail parentDetail = null,
                                        [CallerMemberName] string callerMemberName = "",
                                        [CallerLineNumber] int callerLineNumber = -1,
                                        [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Warning, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static Detail LogDebug(this string message,
                                      Detail parentDetail = null,
                                      [CallerMemberName] string callerMemberName = "",
                                      [CallerLineNumber] int callerLineNumber = -1,
                                      [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Debug, callerMemberName, callerLineNumber, callerFilePath);
        }

        public static Detail LogException(this Exception ex,
                                         Detail parentDetail = null,
                                         [CallerMemberName] string callerMemberName = "",
                                         [CallerLineNumber] int callerLineNumber = -1,
                                         [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(new ExDetail { Ex = ex }, parentDetail, ex.ToString(), Kind.Exception, callerMemberName, callerLineNumber, callerFilePath);
        }

        [Obsolete("Please use LogException for further calls")]
        public static Detail HandleException(this Exception ex,
                                             ExDetail exDetail = null,
                                             [CallerMemberName] string callerMemberName = "",
                                             [CallerLineNumber] int callerLineNumber = -1,
                                             [CallerFilePath] string callerFilePath = "")
        {
            return ex.LogException(exDetail, callerMemberName, callerLineNumber, callerFilePath);
        }
    }
}
