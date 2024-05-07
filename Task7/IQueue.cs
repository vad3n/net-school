namespace Task7
{
    public interface IQueue<T>
    {
        void Enqueue(T e);

        T Dequeue();

        bool IsEmpty();

        int GetCount();

        int GetCapacity();

        T[] GetElements();
    }
}
