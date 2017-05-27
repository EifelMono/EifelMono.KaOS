using System;
namespace EifelMono.KaOS.Implementation
{
    public class IO : IIO
    {
        public bool IsAvailable => true;

        private Lazy<IDirectory> _Directory = new Lazy<IDirectory>(() => new Directory());

        public IDirectory Directory => _Directory.Value;

        private Lazy<IFile> _File = new Lazy<IFile>(() => new File());

        public IFile File => _File.Value;

        private Lazy<IPath> _Path = new Lazy<IPath>(() => new Path());

        public IPath Path => _Path.Value;
    }
}
