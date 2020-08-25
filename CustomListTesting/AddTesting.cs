using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;


namespace CustomListTesting
{
    [TestClass]
    public class AddTesting
    {
        [TestMethod]
        public void Add_Add2Values_CountOf2()
        {
            {
                //arrange

                CustomList<int> customList = new CustomList<int>();
                int value1 = 1;
                int value2 = 2;
                int expected = 2;
                int actual;

                //act
                customList.Add(ref value1);
                customList.Add(ref value2);
                actual = customList.Count;

                //assert
                Assert.AreEqual(expected, actual);
            }

        

        }

        [TestMethod]
        public void Add_Add6Values_CountOf6()
        {
            {
                //arrange

                CustomList<int> customList = new CustomList<int>();
                int value1 = 1;
                int value2 = 2;
                int expected = 6;
                int actual;

                //act
                customList.Add(ref value1);
                customList.Add(ref value2);
                customList.Add(ref value1);
                customList.Add(ref value2);
                customList.Add(ref value1);
                customList.Add(ref value2);
                actual = customList.Count;

                //assert
                Assert.AreEqual(expected, actual);
            }



        }

        [TestMethod]
        public void Add_AddTwoValues_CapacityOf4()
        {
            //arrange

            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 4;
            int actual;

            //act
            customList.Add(ref value1);
            customList.Add(ref value2);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddNineValues_CapacityOf16()
        {
            //arrange

            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 16;
            int actual;

            //act
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value2);

            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddTwoValues_IndexAt0Is1()
        {

            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 1;
            int actual;

            //act
            customList.Add(ref value1);
            customList.Add(ref value2);
            actual = customList[0];

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Add_AddSixValues_IndexAt4Is1()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 1;
            int actual;

            //act
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            actual = customList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddFiveValues_CapacityDoubles()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 8;
            int actual;
            //act
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_AddTenValues_CapacityAtIndex8Is2()
        {
            //arange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;
            //act
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            customList.Add(ref value2);
            customList.Add(ref value1);
            actual = customList[8];

            //assert
            Assert.AreEqual(expected, actual);
        }
        //arange


        //act


        //assert
    }
}
