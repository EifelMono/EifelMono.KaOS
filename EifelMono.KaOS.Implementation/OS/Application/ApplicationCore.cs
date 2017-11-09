using System;

namespace EifelMono.KaOS.Implementation
{
    public class ApplicationCore : IApplication
    {
        #region IDone
        public string ExecutionFileName { get => Environment.GetCommandLineArgs()[0]; }
        #endregion

        #region ITodo

        public virtual bool IsAvailable => throw new NotImplementedException();

        public virtual int Badge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual string Name => throw new NotImplementedException();

        public virtual Version AssemblyVersion => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        public virtual string Version => throw new NotImplementedException();

        public virtual string Build => throw new NotImplementedException();

        public virtual StatusBarStyleKind StatusBarStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual VisibilityKind StatusBarVisibility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void SetStatusBarStyle(StatusBarStyleKind statusBarStyle, bool animated)
        {
            throw new NotImplementedException();
        }

        public virtual void SetStatusBarVisibility(VisibilityKind visibility, bool animated)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
