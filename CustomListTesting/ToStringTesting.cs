using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTesting
{
    [TestClass]
    public class ToStringTesting
    {
        [TestMethod]
        public void ToString_ContentsOfTheCustomList_ReturnsString12()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            string expected = "1, 2";
            string actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToString_ContentsOfTheCustomList_ReturnsString123()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            string expected = "1, 2, 3";
            string actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToString_ContentsOfTheCustomList_EmptyString()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            
            
            string expected = "";
            string actual;

            //act
            customList.Add(value1);
            
            customList.Remove(value1);
            actual = customList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
