using System;
namespace EifelMono.KaOS
{
    public interface IApplication: IAvailable
    {
        int Badge { get; set; }

        string ExecutionFileName { get; }
    }
}
