using QIQO.Services;
using SimpleInjector.Integration.Wcf;
using SM = System.ServiceModel;

namespace QIQO.Console.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = IocContainer.Init();
            
            SM.ServiceHost hostService = new SimpleInjectorServiceHost(container, typeof(Service1));
            hostService.Open();

            System.Console.ReadLine();

            hostService.Close();
        }
    }
}
