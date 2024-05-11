namespace Task7
{
    public static class IQueueExtensions
    {
        public static IQueue<T> Tail<T>(this IQueue<T> queue) where T : struct
        {
            IQueue<T> newQueue = (IQueue<T>)queue.Clone();
            newQueue.Dequeue();

            return newQueue;
        }
    }
}
