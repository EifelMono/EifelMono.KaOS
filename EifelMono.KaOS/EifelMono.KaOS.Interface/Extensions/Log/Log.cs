using System;
using System.Runtime.CompilerServices;

namespace EifelMono.KaOS.Extensions
{
    public static partial class Log
    {
        #region Proxy, gobal call

        /// <summary>
        /// Proxy for the Log
        /// </summary>
        /// <value>The proxy.</value>
        public static ILogProxy Proxy { get; set; } = new DebugLogProxy();


        /// <summary>
        /// Local Log Call
        /// </summary>
        /// <returns>The log.</returns>
        /// <param name="detail">Detail.</param>
        /// <param name="parentDetail">Parent detail.</param>
        /// <param name="message">Message.</param>
        /// <param name="kind">Kind.</param>
        /// <param name="callerMemberName">Caller member name.</param>
        /// <param name="callerLineNumber">Caller line number.</param>
        /// <param name="callerFilePath">Caller file path.</param>
        public static Detail ProxyLog(Detail detail,
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
        #endregion

        #region Trace
        public static partial class Kind
        {
            public static string Trace { get; private set; } = nameof(Trace);
        }

        public static Detail LogTrace(this string message,
                                      Detail parentDetail = null,
                                      [CallerMemberName] string callerMemberName = "",
                                      [CallerLineNumber] int callerLineNumber = -1,
                                      [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Trace, callerMemberName, callerLineNumber, callerFilePath);
        }
        #endregion

        #region Log Info
        public static partial class Kind
        {
            public static string Info { get; private set; } = nameof(Info);
        }

        public static Detail LogInfo(this string message,
                                     Detail parentDetail = null,
                                     [CallerMemberName] string callerMemberName = "",
                                     [CallerLineNumber] int callerLineNumber = -1,
                                     [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Info, callerMemberName, callerLineNumber, callerFilePath);
        }
        #endregion

        #region Log Error
        public static partial class Kind
        {
            public static string Error { get; private set; } = nameof(Error);
        }

        public static Detail LogError(this string message,
                                      Detail parentDetail = null,
                                      [CallerMemberName] string callerMemberName = "",
                                      [CallerLineNumber] int callerLineNumber = -1,
                                      [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Error, callerMemberName, callerLineNumber, callerFilePath);
        }
        #endregion

        #region Log Warning
        public static partial class Kind
        {
            public static string Warning { get; private set; } = nameof(Warning);
        }

        public static Detail LogWarning(this string message,
                                        Detail parentDetail = null,
                                        [CallerMemberName] string callerMemberName = "",
                                        [CallerLineNumber] int callerLineNumber = -1,
                                        [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Warning, callerMemberName, callerLineNumber, callerFilePath);
        }
        #endregion

        #region Log Info
        public static partial class Kind
        {
            public static string Debug { get; private set; } = nameof(Debug);
        }

        public static Detail LogDebug(this string message,
                                      Detail parentDetail = null,
                                      [CallerMemberName] string callerMemberName = "",
                                      [CallerLineNumber] int callerLineNumber = -1,
                                      [CallerFilePath] string callerFilePath = "")
        {
            return ProxyLog(null, parentDetail, message, Kind.Debug, callerMemberName, callerLineNumber, callerFilePath);
        }
        #endregion


        #region Log Info
        public static partial class Kind
        {
            public static string Exception { get; private set; } = nameof(Exception);
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
        #endregion
    }
}
