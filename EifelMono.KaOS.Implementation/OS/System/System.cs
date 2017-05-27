using System;
namespace EifelMono.KaOS.Implementation
{
    public class System : ISystem
    {
        public bool IsAvailable => true;

        private Lazy<IIO> _IO = new Lazy<IIO>(() => new IO());

        public IIO IO => _IO.Value;
    }
}
