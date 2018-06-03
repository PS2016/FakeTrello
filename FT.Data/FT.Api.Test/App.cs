using FT.Mock;
using System;

namespace UD.ApiTest
{
    public class App: IDisposable
    {
        public TestServer Server { get; private set; }
        public DbFactory DbFactory { get; private set; }

        public App()
        {
            Server = new TestServer();
            DbFactory = Server.RootScope.Resolve<DbFactory>();
            DbFactoryDefinitions.Configure(DbFactory);
        }

        public void Dispose()
        {
            Server?.Dispose();
        }
    }
}
