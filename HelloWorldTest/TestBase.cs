using HelloWorldBaseAPI.Services;
using Moq;
using NUnit.Framework;

namespace HelloWorldTest
{
    [TestFixture]
    public class TestBase
    {
        public Mock<IDataService> dataServiceMock;

        public TestBase()
        {
            Initialize();
        }

        [SetUp]
        public void Initialize()
        {
            this.dataServiceMock = new Mock<IDataService>();
          
        }
        
        [TearDown]
        public void CleanUp()
        {
        }
    }
}
