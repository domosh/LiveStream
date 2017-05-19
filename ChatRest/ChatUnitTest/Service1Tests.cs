using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRest.Tests
{
    [TestClass]
    public class Service1Tests
    {
        private readonly IService1 s = new Service1();

        [TestMethod]
        public void GetAllMessagesTest()
        {
           List<Message> result = s.GetAllMessages();
            Assert.AreEqual();
        }

        [TestMethod]
        public void AddMessage()
        {
            string result = s.AddMessage();
            Assert.AreEqual();
        }
    }
}