using AssignmentB;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()

    {
        //This creates an instance of the stack class with stack implementing the IStack interface
        IStack stack = new Stack();

        stack.Push(1); //pushes 1 into the stack
        stack.Push(2); //pushes 2 into the stack
        stack.Push(3); //pushes 3 into the stack

        //Console.WriteLine(stack.Pop()); // 3
        //Console.WriteLine(stack.Pop()); // 2
        //Console.WriteLine(stack.Pop()); // 1

        stack.DisplayArray();
    }
}
