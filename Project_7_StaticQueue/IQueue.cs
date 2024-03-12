namespace StaticQueue
{
    public interface IQueue<T>
    {
        void Enqueue(T value);
        void Clear();
        T Dequeue();
        T Peek();
        bool Contains(T item);
        int Position(T item);
        int Count { get; }
    } //interface}
}
