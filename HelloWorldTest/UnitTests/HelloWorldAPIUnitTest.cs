using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Controllers;
using HelloWorldBaseAPI.Entity;

namespace HelloWorldTest
{
    [TestClass]
    public class HelloWorldAPIUnitTest : TestBase
    {
        private MessageController messageController;

        private  const string ExpectedResult = "Hello World!";

        #region Helloworld API unit test

        /// <summary>
        /// Helloes the world API data success.
        /// </summary>
        [TestMethod]
        public void HelloWorldAPIDataSuccess()
        {
            this.messageController = new MessageController(this.dataServiceMock.Object);

            var expectedMessage = GetMessageEntity();
            dataServiceMock.Setup(m => m.GetMessageData()).Returns(expectedMessage);
            var resultMessage = this.messageController.Get();

            NUnit.Framework.Assert.AreEqual(resultMessage.Body, ExpectedResult);
        }

        #endregion

        #region Helper Methods

        private MessageEntity GetMessageEntity()
        {
            MessageEntity expectedMessage = new MessageEntity();
            expectedMessage.Body = ExpectedResult;

            return expectedMessage;
        }        

        #endregion

    }
}
