using System;
namespace EifelMono.KaOS.Implementation
{
    public class System : ISystem
    {
        public bool IsAvailable => true;

        public IIO IO => (new Lazy<IIO>(() => new IO()).Value);
    }
}
