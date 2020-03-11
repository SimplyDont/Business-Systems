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

        //public static T GetService<T>()
        //{
        //    var instance_ = services_.SingleOrDefault(i => i.ServiceType == typeof(T));
        //    if (instance_.ServiceLifetime == LifeTime.Transient)
        //    {
        //        return (T)Activator.CreateInstance(instance_.ServiceType);
        //    }
        //    else
        //    {
        //         instance_.Implementation;
        //    }
        //}
        
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
