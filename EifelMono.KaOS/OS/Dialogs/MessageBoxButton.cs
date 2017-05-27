using System;
namespace EifelMono.KaOS
{
    [Flags]
    public enum MessageBoxButton
    {
        Ok = 0b0000_0001,
        Cancel= 0b0000_0010,
        Yes= 0b0000_0100,
        None= 0b0000_1000
    }
}
