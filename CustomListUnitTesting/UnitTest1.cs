using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MyCustomList <int> customList = new MyCustomList <int> ();
            int value = 55;
            int expectedCount = 1;
            //Act
            customList.Add(value);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            MyCustomList<int> customList = new MyCustomList<int>();
            MyCustomList<int> load1 = new MyCustomList<int>() { 5 };
            MyCustomList<int> load2 = new MyCustomList<int>() { 10 };
            int expectedValue = 10;

            //Act
            load1 = load1.Zip(load1, load2);

            //Assert
            Assert.AreEqual(expectedValue, load2[0]);
        }


        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            MyCustomList<int> customList = new MyCustomList<int>();
            MyCustomList<int>load1 = new MyCustomList<int>() { 5 };
            MyCustomList<int>load2 = new MyCustomList<int>() { 10 };
            int expectedValue = 5;

            //Act
           load1 = load1.Zip(load1, load2);

            //Assert
            Assert.AreEqual(expectedValue, load1[0]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            MyCustomList<int> customList = new MyCustomList<int>();
            MyCustomList<int> load1 = new MyCustomList<int>() { 5, 15, 25, };
            MyCustomList<int> load2 = new MyCustomList<int>() { 10, 20, 30 };
            int expectedValue = 15;

            //Act
            load1 = load1.Zip(load1, load2);

            //Assert
            Assert.AreEqual(expectedValue, load1[2]);
        }
    }
}
