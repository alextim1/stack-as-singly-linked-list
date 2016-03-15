using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
    public class StackNode<T>
    {
        public StackNode<T> Previous { get; set; }

        public T Data { get; set; }

        public StackNode()
        {
            Previous = null;

            
        }


       
         

       
    }

    public class Stack<T>
    {
        private StackNode<T> _lastInput;


        public Stack ()
        {
            _lastInput = null;//new StackNode<T>();

            //_lastInput.Data = data;

        }

        public void Push (T data)
        {
            StackNode<T> newInput = new StackNode<T>();
            newInput.Data = data;
            newInput.Previous = _lastInput;
            _lastInput = newInput;
        }

        public T Pop ()
        {
            if (_lastInput == null) { throw new InvalidOperationException("Stack underflow!"); }
            T data = _lastInput.Data;
            _lastInput = _lastInput.Previous;
            return data;
        }

        public T Peek ()
        {
            if (_lastInput == null) { throw new InvalidOperationException("Stack underflow!"); }
            return _lastInput.Data;
        }

        public int Count()
        {
            int counter = 0;
            var current = _lastInput;
            while (current!=null)
            {
                current = current.Previous;
                counter++;
            }

            return counter;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> currentStack = new Stack<int>();
            Console.WriteLine(currentStack.Count());
            currentStack.Push(1);
            currentStack.Push(2);
            currentStack.Push(3);
            Console.WriteLine(currentStack.Count());

            Console.WriteLine(currentStack.Pop());
            Console.WriteLine(currentStack.Pop());
            Console.WriteLine(currentStack.Pop());
            Console.ReadKey();
            Console.WriteLine(currentStack.Pop()  );

        }
    }
}
