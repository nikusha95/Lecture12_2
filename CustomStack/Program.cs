// See https://aka.ms/new-console-template for more information

using CustomStack;

MyStack<int> stack = new MyStack<int>();

stack.Push(10);
stack.Push(20);

Console.WriteLine(stack.Peek());