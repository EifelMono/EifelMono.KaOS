namespace EifelMono.KaOS.Implementation.System.IO
{
    public class Path : IPath
    {
        public bool IsAvailable => true;

        public string GetFileName(string path)
        {
            return global::System.IO.Path.GetFileName(path);
        }
    }
}
