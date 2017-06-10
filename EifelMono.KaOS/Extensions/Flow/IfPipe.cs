using System;

namespace EifelMono.KaOS.Extensions
{
    public class IfPipe<T> where T : IComparable
    {
        public T Value { get; set; }
        public bool Done { get; set; } = false;
    }
}
