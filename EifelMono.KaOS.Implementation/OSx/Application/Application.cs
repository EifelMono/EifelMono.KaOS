using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public partial class Application : IApplication
    {
        public string ExecutionFileName => Environment.GetCommandLineArgs()[0];
    }
}
