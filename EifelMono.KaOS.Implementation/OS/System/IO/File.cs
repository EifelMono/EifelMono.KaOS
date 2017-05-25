using System;
using System.IO;

namespace EifelMono.KaOS.Implementation.System.IO
{
    public class File: IFile
    {
        public bool IsAvailable => true;

        public void Copy(string sourceFilName, string destFileName, bool overwrite)
        {
            global::System.IO.File.Copy(sourceFilName, destFileName, overwrite);
        }

        public void Delete(string path)
        {
            global::System.IO.File.Delete(path);
        }

        public bool Exists(string path)
        {
            return global::System.IO.File.Exists(path);
        }

        public void Move(string sourceFilName, string destFileName)
        {
            global::System.IO.File.Move(sourceFilName, destFileName);
        }

        public byte[] ReadAllBytes(string path)
        {
            return global::System.IO.File.ReadAllBytes(path);
        }

        public string ReadAllText(string path)
        {
            return global::System.IO.File.ReadAllText(path);
        }

        public void WriteAllBytes(string path, byte[] bytes)
        {
            global::System.IO.File.WriteAllBytes(path, bytes);
        }

        public void WriteAllText(string path, string text)
        {
            global::System.IO.File.WriteAllText(path, text);
        }
    }
}
