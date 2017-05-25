using System;
namespace EifelMono.KaOS.Implementation.OS
{
    public class System : ISystem
    {
        public bool IsAvailable => true;

        public IIO IO => (new Lazy<IIO>(() => new IO()).Value);
    }
}
