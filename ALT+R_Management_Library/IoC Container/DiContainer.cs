using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALT_R_Management_Library.IoC_Container
{
    public class DiContainer
    {
        private static IList<ServiceDescriptor> services_ = new List<ServiceDescriptor>();
        private static DiContainer diContainer = new DiContainer();
        public static IList<ServiceDescriptor> ServiceDescriptors
        {
            get { return services_; }
            set { services_ = value; }
        }
        public static DiContainer Instance
        {
            get { return diContainer; }
        }

        private static object GetService(Type ServiceType)
        {
            var instance_ = services_.SingleOrDefault(i => i.ServiceType == ServiceType);
            if (instance_.Implementation != null)
            {
                return instance_.Implementation;
            }

            var actualType = instance_.Implementation.GetType() ?? instance_.ServiceType;
            var constructInfo = actualType.GetConstructors().First();
            var parameters=constructInfo.GetParameters().Select(x=>GetService(x.ParameterType)).ToArray();
            var implementation = Activator.CreateInstance(actualType,parameters);
            if (instance_.ServiceLifetime == LifeTime.Singleton)
            {
                return instance_.Implementation = implementation;
            }

            return implementation;
        }

        public static T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }
    }

    public class DiCollection
    {
        private static IList<ServiceDescriptor> services_ = new List<ServiceDescriptor>();
        private static DiCollection diCollection = new DiCollection();
        public static DiCollection Instance
        {
            get { return diCollection; }
        }
        private DiCollection()
        {

        }

        public static void RegisterSingleton<T>()
        {
            services_.Add(new ServiceDescriptor(typeof(T),LifeTime.Singleton));
        }
        public static void RegisterTransient<T>()
        {
            services_.Add(new ServiceDescriptor(typeof(T), LifeTime.Transient));
        }

        public static DiContainer GetContainer()
        {
            DiContainer.ServiceDescriptors = services_;
            return DiContainer.Instance;
        }
    }

    public  class ServiceDescriptor
    {
        

        public Type ServiceType { get; internal set; }
        public object Implementation { get; internal set; }
        public LifeTime ServiceLifetime { get; internal set; }

        public ServiceDescriptor(Type type,LifeTime lifeTime)
        {
            ServiceType = type;
            ServiceLifetime = lifeTime;
        }
    }

    public enum LifeTime
    {
        Singleton,Transient
    }
}
