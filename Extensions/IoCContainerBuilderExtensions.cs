using iocdemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace iocdemo.Extensions
{
    public static class IoCContainerBuilderExtensions
    {
        private const string ConfigureMethodName = "ConfigureServices";

        public static IIoCContainerBuilder UseStartup<T>(this IIoCContainerBuilder ioCContainerBuilder) where T : class
        {
            var type = typeof(T);
            var obj = Activator.CreateInstance(type);
            var configureMethod = type.GetMethod(ConfigureMethodName);
            ioCContainerBuilder.ConfigureServices(i => configureMethod.Invoke(obj, new object[] { i }));

            return ioCContainerBuilder;
        }
    }
}
