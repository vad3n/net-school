namespace Task7
{
    public interface IQueue<T> : ICloneable where T : struct
    {
        void Enqueue(T e);

        T Dequeue();

        bool IsEmpty();
    }
}
