using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentB
{
    public interface IStack
    {
        /// <summary>
        /// Push: This adds an item to the stack.
        /// </summary>
        /// <param name="obj"></param>
        void Push(object obj);

        /// <summary>
        /// Pop: This removes and returns the last most recent item added to the stack
        /// </summary>
        /// <returns></returns>
        object Pop();

        /// <summary>
        /// Clear: This removes all the elements from the stack
        /// </summary>
        void Clear();

        /// <summary>
        /// DisplayArray: This displays all the elements in the array
        /// </summary>
        void DisplayArray();
    }
}
