using System;
namespace EifelMono.KaOS.Extensions
{
    public class LogDetails
    {
        public LogType Type { get; set; }
        public string Value { get; set; }
        public string CallerMemberName { get; set; }
        public int CallerLineNumber { get; set; }
        public string CallerFilePath { get; set; }
    }
}
