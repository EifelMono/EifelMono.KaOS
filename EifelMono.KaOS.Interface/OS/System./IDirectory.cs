using System;
namespace EifelMono.KaOS
{
    public interface IDirectory : IAvailable
    {
        bool Exists(string path);

        void CreateDirectory(string path);

        string[] GetFiles(string path);
    }
}
