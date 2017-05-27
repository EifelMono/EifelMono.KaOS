using System;
using System.Runtime.CompilerServices;

namespace EifelMono.KaOS
{
    public class Developer
    {
        public event Action<string, string, string, int, string> OnAll;

        public event Action<string, string, int, string> OnNotImplemented;

        public void NotImplemented(string message,
                                  [CallerMemberName] string callerMemberName = "",
                                  [CallerLineNumber] int callerLineNumber = -1,
                                  [CallerFilePath] string callerFilePath = "")
        {
            OnAll?.Invoke(nameof(NotImplemented), message, callerMemberName, callerLineNumber, callerFilePath);
            OnNotImplemented?.Invoke(message, callerMemberName, callerLineNumber, callerFilePath);
        }

        public event Action<string, string, int, string> OnNoEquivalentFunctionAvailable;

        public void NoEquivalentFunctionAvailable(string message,
                                  [CallerMemberName] string callerMemberName = "",
                                  [CallerLineNumber] int callerLineNumber = -1,
                                  [CallerFilePath] string callerFilePath = "")
        {
            OnAll?.Invoke(nameof(NoEquivalentFunctionAvailable), message, callerMemberName, callerLineNumber, callerFilePath);
            OnNoEquivalentFunctionAvailable?.Invoke(message, callerMemberName, callerLineNumber, callerFilePath);
        }

        public event Action<string, string, int, string> OnNoOSxNeededUseImplemented;

        public void NoOSxNeededUseImplemented(string message,
                                  [CallerMemberName] string callerMemberName = "",
                                  [CallerLineNumber] int callerLineNumber = -1,
                                  [CallerFilePath] string callerFilePath = "")
        {
            OnAll?.Invoke(nameof(NoOSxNeededUseImplemented), message, callerMemberName, callerLineNumber, callerFilePath);
            OnNoOSxNeededUseImplemented?.Invoke(message, callerMemberName, callerLineNumber, callerFilePath);
        }
    }
}
