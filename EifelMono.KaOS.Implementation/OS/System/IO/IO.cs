using System;
namespace EifelMono.KaOS.Implementation.OS
{
    public class IO : IIO
    {
        public bool IsAvailable => true;

        public IDirectory Directory => (new Lazy<IDirectory>(() => new Directory()).Value);

        public IFile File => (new Lazy<IFile>(() => new File()).Value);

        public IPath Path => (new Lazy<IPath>(() => new Path()).Value);
    }
}
