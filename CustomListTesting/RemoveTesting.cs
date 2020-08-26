using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Runtime.Remoting;

namespace CustomListTesting
{
    [TestClass]
    public class RemoveTesting
    {
        [TestMethod]
        public void Remove_AddThenRemoveValues_CountOf1()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 1;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Remove(value2);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove_Add2IntsAndRemoveFirst_IndexAt0Is2()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Remove(value1);
            actual = customList[0];

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Remove_AddMultipleOfTheSameValuesThenRemove1_IndexAt1Is2()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 2;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value2);
            customList.Remove(value2);
            actual = customList[1];

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Remove_AddMultipleOfTheSameValuesThenRemove2_IndexAt1Is3()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;

            //act
            customList.Add( value1);
            customList.Add( value2);
            customList.Add(value2);
            customList.Add( value3);
            customList.Add( value2);
            customList.Remove(value2);
            customList.Remove(value2);
            actual = customList[1];

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Remove_RemoveValueWhichIsNotThere_CountIs2()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 2;
            int actual;

            //arange
            customList.Add(value1);
            customList.Add(value2);
            customList.Remove(value3);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveValueWhichIsNotThere_BoolIsTrue()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expected = true;
            bool actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            
            actual = customList.Remove(value3);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveValueWhichIsNotThere_BoolIsFalse()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expected = false;
            bool actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            
            actual = customList.Remove(value3);

            //assert
            Assert.AreEqual(expected, actual);
        }
        //arange


        //act


        //assert
    }
}
