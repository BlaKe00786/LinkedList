using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProject;
namespace LinkedListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SeatrchNodeGivenProperValue()
        {
            int expected = 3;
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Add(80);
            int output = list.Search(30);
            Assert.AreEqual(expected,output);
        }
    }
}
