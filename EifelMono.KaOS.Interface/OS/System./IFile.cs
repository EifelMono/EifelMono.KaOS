using System;
using System.IO;

namespace EifelMono.KaOS
{
    public interface IFile : IAvailable
    {
        void Copy(string sourceFilName, string destFileName, bool overwrite);

        void Delete(string path);

        bool Exists(string path);

        void Move(string sourceFilName, string destFileName);

        byte[] ReadAllBytes(string path);

        string ReadAllText(string path);

        void WriteAllText(string path, string text);

        void WriteAllBytes(string path, byte[] bytes);
    }
}
