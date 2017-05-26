using System;
namespace EifelMono.KaOS.Implementation
{
    public class Directory : IDirectory
    {
        public bool IsAvailable => true;

        public void CreateDirectory(string path)
        {
            global::System.IO.Directory.CreateDirectory(path);
        }

        public bool Exists(string path)
        {
            return global::System.IO.Directory.Exists(path);
        }

        public string[] GetFiles(string path)
        {
            return global::System.IO.Directory.GetFiles(path);
        }

        public string[] GetFiles(string path, string searchPattern)
        {
            return global::System.IO.Directory.GetFiles(path, searchPattern);
        }
    }
}
