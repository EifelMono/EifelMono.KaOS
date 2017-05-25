using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EifelMono.KaOS
{
    public static class BackDoor
    {
        #region Definition

        internal class Item
        {
            private Type m_ClassType;

            internal Type ClassType
            {
                get { return m_ClassType; }
                set
                {
                    m_ClassType = value;
                    ClassTypeInfo = value.GetTypeInfo();
                }
            }

            internal TypeInfo ClassTypeInfo { get; set; }

            private Type m_InterfaceType;

            internal Type InterfaceType
            {
                get { return m_InterfaceType; }
                set
                {
                    m_InterfaceType = value;
                    InterfaceTypeInfo = value.GetTypeInfo();
                }
            }

            internal TypeInfo InterfaceTypeInfo { get; set; }

            internal object Instance { get; set; }
        }

        internal static List<Item> Items { get; private set; } = new List<Item>();

        /// <summary>
        /// Init the specified assemblies.
        /// </summary>
        /// <param name="assemblies">Assemblies.</param>
        public static void Init(IEnumerable<Assembly> assemblies)
        {
            foreach (Assembly assembly in assemblies)
            {
                object[] attributes = assembly.GetCustomAttributes(typeof(BackDoorAttribute)).ToArray<Attribute>();
                if (attributes.Length != 0)
                    foreach (BackDoorAttribute attribute in attributes)
                        Items.Add(new Item() { ClassType = attribute.ClassType });
            }
        }

        #endregion

        #region Create

        /// <summary>
        /// Mode.
        /// </summary>
        internal enum Mode
        {
            Instance,
            New,
        }

        /// <summary>
        /// Get the specified mode.
        /// </summary>
        /// <param name="mode">Mode.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        internal static T Get<T>(Mode mode) where T : class
        {
            Type interfaceType = typeof(T);
            TypeInfo interfaceTypeInfo = interfaceType.GetTypeInfo();
            Item item = Items.FirstOrDefault(i => i.InterfaceType == interfaceType);
            if (item == null)
            {
                // from interface to class !
                item = Items.FirstOrDefault(a => interfaceTypeInfo.IsAssignableFrom(a.ClassTypeInfo));
                if (item != null)
                    item.InterfaceType = interfaceType;
            }
            if (item != null)
            {
                if (mode == Mode.New)
                    return (T)Activator.CreateInstance(item.ClassType);
                else
                {
                    if (item.Instance == null)
                        item.Instance = (T)Activator.CreateInstance(item.ClassType);
                    return (T)item.Instance;
                }
            }

            return null;

        }

        /// <summary>
        /// New this instance.
        /// </summary>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T New<T>() where T : class
        {
            return Get<T>(BackDoor.Mode.New);
        }

        /// <summary>
        /// Instance this instance.
        /// </summary>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T Instance<T>() where T : class
        {
            return Get<T>(BackDoor.Mode.Instance);
        }
        #endregion
    }
}
