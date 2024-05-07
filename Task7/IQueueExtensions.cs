namespace Task7
{
    public static class IQueueExtensions
    {
        public static IQueue<T> Tail<T>(this IQueue<T> queue)
        {
            IQueue<T> newQueue = new Task7.Queue<T>(queue.GetCapacity());
            T[] elements = queue.GetElements();

            if (queue.IsEmpty())
            {
                return newQueue;
            }

            for (int i = 1; i < queue.GetCount(); i++)
            {
                newQueue.Enqueue(elements[i]);
            }

            return newQueue;
        }
    }
}
