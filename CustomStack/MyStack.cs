namespace CustomStack;

public class MyStack<T>
{
    private List<T> _stack;

    public MyStack(List<T> stack)
    {
        _stack = stack;
    }

    public MyStack()
    {
        _stack = new List<T>();
    }

    public void Pop()
    {
        if (_stack.Count == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty");
        }

        _stack.RemoveAt(_stack.Count - 1);
    }

    public void Push(T element)
    {
        _stack.Add(element);
    }

    public int Size()
    {
        return _stack.Count;
    }

    public T Peek()
    {
        if (_stack.Count == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty");
        }

        return _stack[^1]; //_stack.Count-1
    }
}