using SimpleInjector;
using SimpleInjector.Integration.Wcf;
using System;

namespace QIQO.Services
{
    public static class IocContainer
    {
        public static Container Container { get; private set; }

        public static Container Init()
        {
            var _container = new Container();
            _container.Options.DefaultScopedLifestyle = new WcfOperationLifestyle();

            _container.Register<IRepoFactory, RepoFactory>();
            _container.Register<ITestRepo1, TestRepo1>();
            _container.Register<ITestRepo2, TestRepo2>();
            _container.Register<ITestRepo3, TestRepo3>();

            _container.Register<ITestService, TestService>(Lifestyle.Singleton);
            _container.Register<IService1, Service1>();

            Container = _container;
            _container.Verify();
            return _container;
        }
    }
}
