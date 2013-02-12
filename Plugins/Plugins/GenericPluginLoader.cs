using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace GridironMaidenEngine.Plugins
{
    /// <summary>
    /// Generic Plugin/Type loader.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericPluginLoader<T> where T: class
    {
        /// <summary>
        /// Loads all available plugins from the file of type T.
        /// </summary>
        /// <param name="path">Path to .net assembly.</param>
        /// <returns></returns>
        public Collection<T> LoadPlugins(string path)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFile(Path.GetFullPath(path));
            }
            catch
            {
                //TODO: Add code here
            }

            
            Collection<T> plugins = new Collection<T>();
            if (assembly != null)
            {
                try
                {
                    plugins = LoadPlugins(assembly);
                }
                catch
                {
                }
            }

            return plugins;
        }
        /// <summary>
        /// Loads all available plugins from the assembly of type T.
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public Collection<T> LoadPlugins(Assembly assembly)
        {
                Collection<T> types = new Collection<T>();
                foreach (Type t in assembly.GetTypes())
                {
                    // Here we are checking to see if 
                    if (typeof(T).IsAssignableFrom(t))                        
                    {
                        // You should wrap this in error handling.
                        T plugin = Activator.CreateInstance(t) as T;
                        types.Add(plugin);
                    }
                }

                return types;            
        }
    }
}
