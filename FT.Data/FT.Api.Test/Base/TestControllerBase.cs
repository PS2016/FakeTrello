using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UD.ApiTest.Base
{
    public class TestControllerBase
    {
        protected App App;

        [TestInitialize]
        public virtual void Init()
        {
            App = new App();
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            App?.Dispose();
        }

    }
}
