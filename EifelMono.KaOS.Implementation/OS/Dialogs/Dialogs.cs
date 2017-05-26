using System;
namespace EifelMono.KaOS.Implementation.OS
{
    public class Dialogs
    {
        public bool IsAvailable => Implementation != null && Implementation.IsAvailable;

        public static IDialogs Implementation => new Lazy<IDialogs>(() => new Real.Dialogs()).Value;
    }
}
