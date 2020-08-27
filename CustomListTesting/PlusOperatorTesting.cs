using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTesting
{
    [TestClass]
    public class PlusOperatorTesting
    {
        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_ReturnsCountOf6()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 6;
            int actual;

            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual = result.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_IndexAt3Is4()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 4;
            int actual;

            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual = result[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_IndexAt0Is1()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            
            int expected = 1;
            int actual;

            //act
            listOne.Add(value1);
            listOne.Add(value1);
            
            listTwo.Add(value2);
            listTwo.Add(value2);
            
            actual = result[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_Capacityof8()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 8;
            int actual;

            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual = result.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_Capacityof16()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            
            int expected = 16;
            int actual;

            //act
            listOne.Add(value1);
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual = result.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_CountOf3()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;

            int expected = 3;
            int actual;

            //act
            listOne.Add(value1);
            listOne.Add(value1);

            listOne.Add(value2);
            listTwo.Add(value1);
            listTwo.Remove(value1);
            

            actual = result.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
