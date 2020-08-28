using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTesting
{
    [TestClass]
    public class ZipTesting
    {
        [TestMethod]
        
        public void ZipOperator_ContentsOfTheCustomLists_ReturnsCountOf6()
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
            
            actual += listOne.Zip(listTwo);
            
            //assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]

        public void ZipOperator_ContentsOfTheCustomLists_ReturnsCapacityOf8()
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

            actual += listOne.Zip(listTwo);

            //assert
            Assert.AreEqual(expected, actual.Capacity);
        }

        [TestMethod]
        public void ZipOperator_ContentsOfTheCustomLists_ReturnsIndexAt3Is4()
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
            int expected = 4;


            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);

            actual += listOne.Zip(listTwo);

            //assert
            Assert.AreEqual(expected, actual[3]);
        }

        [TestMethod]
        public void ZipOperator_ContentsOfTheCustomLists_ReturnsIndexAt1Is2()
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
            int expected = 2;


            //act
            listOne.Add(value1);
            listOne.Add(value3);
            listOne.Add(value5);
            listTwo.Add(value2);
            listTwo.Add(value4);
            listTwo.Add(value6);

            actual += listOne.Zip(listTwo);

            //assert
            Assert.AreEqual(expected, actual[1]);
        }
    }
}
