

using System;

namespace QIQO.Services
{
    public class TestService : ITestService
    {
        public TestService()
        {
            Console.WriteLine("TestService ctor");
        }
    }

    public interface ITestService { }
}
