using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTesting
{
    [TestClass]
    public class MinusOperatorTesting
    {
        [TestMethod]
        public void MinusOperator_ContentsOfTheCustomLists_ReturnsCountOf2()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            
            int value5 = 5;
            int value6 = 6;
            int expected = 2;


            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value1);
            listTwo.Add(value6);
            
            actual = listOne - listTwo;
            //assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void MinusOperator_ContentsOfTheCustomLists_ReturnsIndexAt0Is3()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            
            int value5 = 5;
            int value6 = 6;
            int expected = 3;


            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value1);
            listTwo.Add(value6);

            actual = listOne - listTwo;
            //assert
            Assert.AreEqual(expected, actual[0]);
        }

        [TestMethod]
        public void MinusOperator_ContentsOfTheCustomLists_CapacityOf4()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            
            int value5 = 5;
            int value6 = 6;
            int expected = 4;


            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value1);
            listTwo.Add(value6);

            actual = listOne - listTwo;
            //assert
            Assert.AreEqual(expected, actual.Capacity);
        }


        

        
        

        [TestMethod]
        public void MinusOperator_ContentsOfTheCustomLists_CountOf3()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            int expected = 3;


            //act
            listOne.Add(value1);
            listOne.Add(value2);
            listOne.Add(value3);

            
            listTwo.Add(value1);
            listTwo.Remove(value1);


            
            actual = listOne - listTwo;

            //assert
            Assert.AreEqual(expected, actual.Count);
        }

        public void MinusOperator_ContentsOfTheCustomLists_IndexAt2Is3()
        {
            //arange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            int expected = 3;


            //act
            listOne.Add(value1);
            listOne.Add(value2);
            listOne.Add(value3);


            listTwo.Add(value1);
            listTwo.Remove(value1);



            actual = listOne - listTwo;

            //assert
            Assert.AreEqual(expected, actual[2]);
        }
    }
}
