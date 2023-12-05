using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools
{
    public static class Utils
    {
        public static List<T> GetClassesOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();

            var types = Assembly.GetAssembly(typeof(T))?.GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)));

            if (types == null) return objects;

            foreach (Type type in types)
            {
                var instance = Activator.CreateInstance(type, constructorArgs);

                if (instance == null) continue;

                objects.Add((T)instance);
            }

            return objects;
        }
    }
}

