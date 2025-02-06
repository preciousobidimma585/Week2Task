internal class SinglyLinkedList<T>
{
    public SinglyLinkedList()
    {
    }

    internal void Add(int v)
    {
        throw new NotImplementedException();
    }

    internal bool Check(int v)
    {
        throw new NotImplementedException();
    }

    internal bool Index(int v)
    {
        throw new NotImplementedException();
    }

    internal void Print()
    {
        throw new NotImplementedException();
    }

    internal bool Remove(int v)
    {
        throw new NotImplementedException();
    }
}
class program
{
    static void Main()
    {
        
        var list = new SinglyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Print();

        Console.WriteLine(list.Remove(2)); 
        list.Print();

        Console.WriteLine(list.Check(3)); 
        Console.WriteLine(list.Index(3)); 

        
        var stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek()); 

        
        var queue = new Queue<int>();
        queue.Enqueue(100);
        queue.Enqueue(200);
        Console.WriteLine(queue.Dequeue()); 
    }
}

