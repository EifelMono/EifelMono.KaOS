using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Tourch : ITourch
    {
        public bool IsAvailable => true;

        public bool Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
