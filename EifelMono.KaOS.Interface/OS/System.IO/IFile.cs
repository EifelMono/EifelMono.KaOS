using System;
using System.IO;

namespace EifelMono.KaOS
{
    public interface IFile : IAvailable
    {
        string CurrentPath { get; }

        string DocumentsPath(string relativeFilename);

        void WriteAllText(string relativeFileName, string text);

        string ReadAllText(string relativeFileName);

        void WriteAllBytes(string relativeFilename, byte[] bytes);

        byte[] ReadAllBytes(string relativeFilename);

        bool Exists(string relativeFileName, bool withDocumentsPath = true);

        void Delete(string relativeFileName);

        void Copy(string sourceFilName, string destFileName, bool overwrite);

        void Move(string sourceFilName, string destFileName);

        void Save(Stream stream, string filename);
    }
}
