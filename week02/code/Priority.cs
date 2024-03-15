public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements

        // Test Cases

        // Test 1 -- This satisfies requirement # 4
        // Scenario: If we try to Dequeue someone when the queue is empty, console log that it's empty.
        // Expected Result: Console log says "The queue is empty."
        Console.WriteLine("Test 1");
        var priorityQueue1 = new PriorityQueue();
        priorityQueue1.Dequeue();

        // Defect(s) Found: No defects found

        Console.WriteLine("\n---------\n");

        // Test 2 -- This satisfies requirement # 1
        // Scenario: Add items (which contains both data and priority) to the back of the queue.
        // Expected Result:  John (Pri: 1), Alice (Pri: 7), Henry (Pri: 3)
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();

        priorityQueue2.Enqueue("John", 1);
        priorityQueue2.Enqueue("Alice", 7);
        priorityQueue2.Enqueue("Henry", 3);
        Console.WriteLine(priorityQueue2);

        // Defect(s) Found: No defects found

        Console.WriteLine("\n---------\n");

        // Test 3 -- This satisfies requirements # 2 & 3
        // Scenario: Remove the item with the highest priority and return its value.
        // Expected Result: Grace
        Console.WriteLine("Test 3");
        var priorityQueue3 = new PriorityQueue();

        priorityQueue3.Enqueue("Sarah", 4);
        priorityQueue3.Enqueue("Grace", 8);
        priorityQueue3.Enqueue("Spencer", 4);
        priorityQueue3.Enqueue("Jessica", 2);
        priorityQueue3.Enqueue("James", 8);


        var dequeued = priorityQueue3.Dequeue();
        Console.WriteLine(dequeued);

        // Uncommment the next "while" loop to help w/ debug. This dequeues & prints every person in order of priority
        // while (priorityQueue3.Count > 0) {
        //     var dequeued = priorityQueue3.Dequeue();
        //     Console.WriteLine(dequeued);
        // }

        // Defect(s) Found:
        // 1. The Dequeue function does not remove anything.
        // 2. The Dequeue function's for loop started at index 1 so it skipped the first item.
        // 3. The Dequeue function's for loop's condition only used "less than" (<) which skips the last item.
        // 4. The Dequeue function does not check for items that have the same priority and does not return the first duplicate.

        // Fix:
        // 1. Make Dequeue function remove item with highest priority -- { _queue.RemoveAt(highPriorityIndex); }
        // 2. Make Dequeue function's for loop start at index 0 -- { int index = 0; }
        // 3. Make Dequeue function's for loop's condition use "less than or equal to" -- { index <= _queue.Count - 1; }
        // 4. Make Dequeue function's for loop check if the current item's priority is equal to the current highest priority. If yes, that item is skipped and the loop moves to the next item. -- { if (_queue[index].Priority == _queue[highPriorityIndex].Priority && index > 0) { continue; }

        Console.WriteLine("\n---------\n");

    }
}