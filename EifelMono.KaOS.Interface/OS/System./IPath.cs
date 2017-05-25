using System;
namespace EifelMono.KaOS
{
    public interface IPath: IAvailable
    {
        string GetFileName(string path);
    }
}
