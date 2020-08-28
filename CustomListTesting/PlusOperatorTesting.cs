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
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 6;
            

            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual.Capacity = listOne.Capacity +listTwo.Capacity;
            actual = listOne + listTwo;
            //assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_IndexAt3Is2()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 2;


            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual.Capacity = listOne.Capacity + listTwo.Capacity;
            actual = listOne + listTwo;
            //assert
            Assert.AreEqual(expected, actual[3]);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_IndexAt0Is1()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            
            int expected = 1;
            

            //act
            listOne.Add(value1);
            listOne.Add(value1);
            
            listTwo.Add(value2);
            listTwo.Add(value2);
            actual.Capacity = listOne.Capacity + listTwo.Capacity;
            actual = listOne + listTwo;


            //assert
            Assert.AreEqual(expected, actual[0]);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_Capacityof8()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 8;
            

            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);
            actual.Capacity = listOne.Capacity + listTwo.Capacity;
            actual = listOne + listTwo;


            //assert
            Assert.AreEqual(expected, actual.Capacity);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_Capacityof16()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            
            int expected = 16;
            

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
            actual.Capacity = listOne.Capacity + listTwo.Capacity;
            actual = listOne + listTwo;

            //assert
            Assert.AreEqual(expected, actual.Capacity);
        }

        [TestMethod]
        public void PlusOperator_ContentsOfTheCustomLists_CountOf3()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;

            int expected = 3;
            

            //act
            listOne.Add(value1);
            listOne.Add(value1);

            listOne.Add(value2);
            listTwo.Add(value1);
            listTwo.Remove(value1);


            actual.Capacity = listOne.Capacity + listTwo.Capacity;
            actual = listOne + listTwo;

            //assert
            Assert.AreEqual(expected, actual.Count);
        }
    }
}
