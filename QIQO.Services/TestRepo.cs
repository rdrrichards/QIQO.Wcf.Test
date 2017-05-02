namespace QIQO.Services
{
    public interface ITestRepo
    {
        string RepoName { get; }
    }

    public interface ITestRepo1 : ITestRepo { }
    public interface ITestRepo2 : ITestRepo { }
    public interface ITestRepo3 : ITestRepo { }

    public class TestRepoBase : ITestRepo { public virtual string RepoName => "TestRepoBase"; }

    public class TestRepo1 : TestRepoBase, ITestRepo1
    {
        public override string RepoName => "TestRepo1";
    }
    public class TestRepo2 : TestRepoBase, ITestRepo2
    {
        public override string RepoName => "TestRepo2";
    }
    public class TestRepo3 : TestRepoBase, ITestRepo3
    {
        // public override string RepoName => "TestRepo3";
    }

    public interface IRepoFactory { T GetRepo<T>() where T : class, ITestRepo; }
    public class RepoFactory : IRepoFactory
    {
        public T GetRepo<T>() where T : class, ITestRepo
        {
            return IocContainer.Container.GetInstance<T>();
        }
    }
}
