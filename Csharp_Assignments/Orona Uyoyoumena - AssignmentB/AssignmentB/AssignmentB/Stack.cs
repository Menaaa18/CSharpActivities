using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentB
{
    public class Stack : IStack
    {
        private object[] _stackArray = new object[2]; // Initial array to store stack elements
        private int _size = 0; // Tracks the number of elements in the stack

        // Push: Adds an element to the stack
        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("Cannot add null to the stack.");

            // If the array is full, double its size
            if (_size == _stackArray.Length)
                ExpandArray();

            _stackArray[_size] = item; // Store the item
            _size++; // Increase the size count
        }

        // Pop: Removes and returns the last added element (LIFO)
        public object Pop()
        {
            if (_size == 0)
                throw new InvalidOperationException("Stack is empty.");

            _size--; // Decrement size before retrieving the last item
            var lastItem = _stackArray[_size]; // Retrieve last item
            _stackArray[_size] = null; // Remove reference for garbage collection
            return lastItem; // Return the popped item
        }

        // Clear: Empties the entire stack
        public void Clear()
        {
            for (int i = 0; i < _size; i++)
                _stackArray[i] = null; // Remove all items

            _size = 0; // Reset stack size
        }

        // ExpandArray: Doubles the size of the array when full
        private void ExpandArray()
        {
            Array.Resize(ref _stackArray, _stackArray.Length * 2);
        }

        // DisplayArray: Prints all elements in the stack
        public void DisplayStack()
        {
            foreach (var element in _stackArray)
            {
                if (element == null) // Ignore null values
                    continue;

                Console.Write($"{element} "); // Print element
            }
            Console.WriteLine(); // New line after displaying elements
        }

        public void DisplayArray()
        {
            throw new NotImplementedException();
        }
    }
}
