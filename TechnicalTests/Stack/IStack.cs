namespace TechnicalTests.Stack
{
    public interface IStack<T>
    {
        bool Push(T item);

        T Pop();

        T Peek();

        void Clear();

        bool Contains(T item);

        int Count();

    }
}
