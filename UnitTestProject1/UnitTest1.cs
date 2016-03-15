using System;
using STACK;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void ValidPushPop()
        {
            // arrangement
            Stack<int> currentStack = new Stack<int>();
            currentStack.Push(1);
            currentStack.Push(2);
            currentStack.Push(3);

            // assert

            Assert.AreEqual(3, currentStack.Pop());
        }


        [TestMethod]

        public void ValidAmountCount()
        {
            // arrangement
            Stack<int> currentStack = new Stack<int>();
            currentStack.Push(1);
            currentStack.Push(2);
            currentStack.Push(3);

            // assert

            Assert.AreEqual(3, currentStack.Count());
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionOnTryingGetValueFromEmptyStack()
        {
            // arrangement
            Stack<int> currentStack = new Stack<int>();
            currentStack.Push(1);
            currentStack.Push(2);
            currentStack.Push(3);

            // assert
            Console.WriteLine(currentStack.Pop());
            Console.WriteLine(currentStack.Pop());
            Console.WriteLine(currentStack.Pop());
            Console.WriteLine(currentStack.Pop());
        }
    }


}
