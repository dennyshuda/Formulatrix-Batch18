using Generics;

CustomStack<int> stack = new(2);

Console.WriteLine(stack.IsEmpty);

stack.ShowStackInfo();

stack.Push(1);

stack.Peek();

stack.Push(10);

stack.Push(20);

stack.Peek();

Console.WriteLine(stack.Peek());

stack.ShowStackInfo();

Console.WriteLine(stack.First());

stack.Clear();

stack.ShowStackInfo();

