using System;

namespace EifelMono.KaOS.Implementation
{
    public class TourchCore : ITourch
    {
        public virtual bool Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual bool IsAvailable => throw new NotImplementedException();
    }
}
