using System;

namespace EifelMono.KaOS.Platform
{
    public class TourchCore : ITourch
    {
        public virtual bool Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual bool IsAvailable => throw new NotImplementedException();
    }
}
