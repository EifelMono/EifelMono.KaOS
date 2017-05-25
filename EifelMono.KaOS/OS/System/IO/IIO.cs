using System;
namespace EifelMono.KaOS
{
    public interface IIO: IAvailable
    {
        IDirectory Directory { get; }

        IFile File { get; }

        IPath Path { get; }
    }
}
