using System;

namespace EifelMono.KaOS
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public class BackDoorAttribute : Attribute
    {
        internal Type ClassType { get; private set; }

        public BackDoorAttribute(Type classType)
        {
            this.ClassType = classType;
        }
    }
}
