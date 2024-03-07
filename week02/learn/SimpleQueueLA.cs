public class SimpleQueueLA {
    public static void Run() {
        var queue = new Queue<int>();
        queue.Enqueue(1); // Add '1' to the back of the queue -- { 1 }
        Console.WriteLine($"\nqueue.Enqueue(1):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(2); // Add '2' to the back of the queue -- { 1, 2 }
        Console.WriteLine($"\nqueue.Enqueue(2):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(3); // Add '3' to the back of the queue -- { 1, 2, 3 }
        Console.WriteLine($"\nqueue.Enqueue(3):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        var dequeued = queue.Dequeue(); // Remove the first item '1' from the front of the queue -- { 2, 3 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '2' from the front of the queue -- { 3 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(4); // Add '4' to the back of the queue -- { 3, 4 }
        Console.WriteLine($"\nqueue.Enqueue(4):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(5); // Add '5' to the back of the queue -- { 3, 4, 5 }
        Console.WriteLine($"\nqueue.Enqueue(5):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '3' from the front of the queue -- { 4, 5 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(6); // Add '6' to the back of the queue -- { 4, 5, 6 }
        Console.WriteLine($"\nqueue.Enqueue(6):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(7); // Add '7' to the back of the queue -- { 4, 5, 6, 7 }
        Console.WriteLine($"\nqueue.Enqueue(7):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(8); // Add '8' to the back of the queue -- { 4, 5, 6, 7, 8 }
        Console.WriteLine($"\nqueue.Enqueue(8):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(9); // Add '9' to the back of the queue -- { 4, 5, 6, 7, 8, 9 }
        Console.WriteLine($"\nqueue.Enqueue(9):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '4' from the front of the queue -- { 5, 6, 7, 8, 9 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '5' from the front of the queue -- { 6, 7, 8, 9 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(10); // Add '10' to the back of the queue -- { 6, 7, 9, 10 }
        Console.WriteLine($"\nqueue.Enqueue(10):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '6' from the front of the queue -- { 7, 8, 9, 10 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '7' from the front of the queue -- { 8, 9, 10 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '8' from the front of the queue -- { 9, 10 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(11); // Add '11' to the back of the queue -- { 9, 10, 11 }
        Console.WriteLine($"\nqueue.Enqueue(11):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(12); // Add '12' to the back of the queue -- { 9, 10, 11, 12 }
        Console.WriteLine($"\nqueue.Enqueue(12):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '9' from the front of the queue -- { 10, 11, 12 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '10' from the front of the queue -- { 11, 12 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '11' from the front of the queue -- { 12 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(13); // Add '13' to the back of the queue -- { 12, 13 }
        Console.WriteLine($"\nqueue.Enqueue(13):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(14); // Add '14' to the back of the queue -- { 12, 13, 14 }
        Console.WriteLine($"\nqueue.Enqueue(14):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));


        queue.Enqueue(15); // Add '15' to the back of the queue -- { 12, 13, 14, 15 }
        Console.WriteLine($"\nqueue.Enqueue(15):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(16); // Add '16' to the back of the queue -- { 12, 13, 14, 15, 16 }
        Console.WriteLine($"\nqueue.Enqueue(16):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '12' from the front of the queue -- { 12, 13, 14, 15, 16 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '13' from the front of the queue -- { 14, 15, 16 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '14' from the front of the queue -- { 15, 16 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(17); // Add '17' to the back of the queue -- { 15, 16, 17 }
        Console.WriteLine($"\nqueue.Enqueue(17):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(18); // Add '18' to the back of the queue -- { 15, 16, 17, 18 }
        Console.WriteLine($"\nqueue.Enqueue(18):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '15' from the front of the queue -- { 16, 17, 18 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(19); // Add '19' to the back of the queue -- { 17, 18, 19 }
        Console.WriteLine($"\nqueue.Enqueue(19):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        queue.Enqueue(20); // Add '20' to the back of the queue -- { 17, 18, 19, 20 }
        Console.WriteLine($"\nqueue.Enqueue(20):");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '16' from the front of the queue -- { 17, 18, 19, 20 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        dequeued = queue.Dequeue(); // Remove the first item '17' from the front of the queue -- { 18, 19, 20 }
        Console.WriteLine($"\nqueue.Dequeue(): - {dequeued}");
        Console.WriteLine(String.Join(", ", queue.ToArray()));


        Console.WriteLine("\nFinal contents:"); // { 18, 19, 20 }
        Console.WriteLine(String.Join(", ", queue.ToArray())); // "18, 19, 20"
    }
}