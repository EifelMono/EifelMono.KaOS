using System;
using System.Runtime.CompilerServices;

namespace EifelMono.KaOS
{
    public class Developer
    {
        public event Action<Exception> OnException;

        public void Exception(Exception ex)
        {
            OnException?.Invoke(ex);
        }

        public event Action<string, string, int, string> OnNotImplemented;

        public void NotImplemented(string message,
                                  [CallerMemberName] string callerMemberName = "",
                                  [CallerLineNumber] int callerLineNumber = -1,
                                  [CallerFilePath] string callerFilePath = "")
        {
            OnNotImplemented?.Invoke(message, callerMemberName, callerLineNumber, callerFilePath);
        }

        public event Action<string, string, int, string> OnNoEquivalentFunctionAvailable;

        public void NoEquivalentFunctionAvailable(string message,
                                  [CallerMemberName] string callerMemberName = "",
                                  [CallerLineNumber] int callerLineNumber = -1,
                                  [CallerFilePath] string callerFilePath = "")
        {
            OnNoEquivalentFunctionAvailable?.Invoke(message, callerMemberName, callerLineNumber, callerFilePath);
        }
    }
}
