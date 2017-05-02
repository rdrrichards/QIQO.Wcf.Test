using System;

namespace QIQO.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private readonly ITestService _testService;
        private readonly IRepoFactory _repoFactory;

        public Service1(ITestService testService, IRepoFactory repoFactory)
        {
            _testService = testService;
            _repoFactory = repoFactory;
        }
        public string GetData(int value)
        {
            var trepo = _repoFactory.GetRepo<ITestRepo3>();
            return $"Value: {value}; Repo: {trepo.RepoName}";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
