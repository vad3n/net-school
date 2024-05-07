using Task7;

IQueue<int> queue1 = new Task7.Queue<int>(10);
Console.WriteLine(queue1.IsEmpty());
queue1.Enqueue(1);
queue1.Enqueue(2);
queue1.Enqueue(3);
queue1.Enqueue(4);
queue1.Enqueue(5);
queue1.Enqueue(6);
queue1.Dequeue();
queue1.Enqueue(7);
queue1.Enqueue(8);
queue1.Enqueue(9);
queue1.Enqueue(10);
queue1.Dequeue();
queue1.Enqueue(11);
queue1.Enqueue(12);
//queue1.Enqueue(13);

IQueue<int> queue2 = new Task7.Queue<int>(5);
queue2.Enqueue(1);
queue2.Enqueue(2);
queue2.Enqueue(3);
queue2.Enqueue(4);
Console.WriteLine(queue2.IsEmpty());

IQueue<int> queue3 = queue2.Tail();
queue2.Enqueue(5);
queue3.Enqueue(6);
queue3.Enqueue(7);