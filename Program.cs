namespace StackQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Insert(70);
            //linkedListStack.Insert(30);
            //linkedListStack.Insert(56);
            //linkedListStack.Display();
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //linkedListStack.Display();

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}