using System;
using Lab6Variant10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1Method1()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = 1; // например, заполняем такими числами
                }
            }
            int expected = 0;
            int actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test2Method1()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = 2; // например, заполняем такими числами
                }
            }
            int expected = 0;
            int actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test3Method1()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = -1; // например, заполняем такими числами
                }
            }
            int expected = 105;
            int actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test4Method1()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = i - 1; // например, заполняем такими числами
                }
            }
            int expected = 1;
            int actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test5Method1()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = i - 2; // например, заполняем такими числами
                }
            }
            int expected = 3;
            int actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test1Method2()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = 1; // например, заполняем такими числами
                }
            }
            double[] expected = new double[] { };
            double[] actual = Class1.method2();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test2Method2()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = -1; // например, заполняем такими числами
                }
            }
            double[] expected = new double[105];
            for (int i = 0; i < 105; i++)
            {
                expected[i] = -1;
            }

            double[] actual = Class1.method2();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test3Method2()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = 0; // например, заполняем такими числами
                }
            }
            double[] expected = new double[] { };

            double[] actual = Class1.method2();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test4Method2()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = i-1; // например, заполняем такими числами
                }
            }
            double[] expected = new double[] { -1 };

            double[] actual = Class1.method2();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test5Method2()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Class1.matrix[i, j] = i - 2; // например, заполняем такими числами
                }
            }
            double[] expected = new double[] { -2, -1, -1 };

            double[] actual = Class1.method2();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
