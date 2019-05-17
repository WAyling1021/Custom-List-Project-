using System;
using System.IO;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNumber_CheckNumber1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 7;
            int expected = 7; 

            //Act
            myList.Add(value);
            int actual = myList.items[0];

            //Assert
            Assert.AreEqual(expected, actual); 

        }
        [TestMethod]
        public void AddNumber_CheckNumber2()
        { 
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 8;
            int expected = 8;

            //Act
            myList.Add(value);
            myList.Add(value1);
            int actual = myList.items[1]; 

            //Assert
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void AddCount_CheckCount1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 8;
            int expected = 2;

            //Act
            myList.Add(value);
            myList.Add(value1);
            int actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);  
        }
        [TestMethod]
        public void AddCount_CheckCount2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 8;
            int value2 = 7;
            int expected = 3;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            
            int actual = myList.Count; 

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCapacity_CheckCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;

            //Act
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);
            myList.Add(78);


            //Assert
            //Assert.AreEqual(expected, myList[0]);

        }












    }
}
