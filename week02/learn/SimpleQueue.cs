public class SimpleQueue {
    public static void Run() {
        // Test Cases

        // Test 1
        // Scenario: Enqueue one value and then Dequeue it.
        // Expected Result: It should display 100
        Console.WriteLine("Test 1");
        var queue = new SimpleQueue();
        queue.Enqueue(100);
        var value = queue.Dequeue();
        Console.WriteLine(value);
        // Defect(s) Found:
        // -- "Dequeue" method is trying to 1) find an item at index 1, then 2) remove that same item from index 1, but there is only one item in the queue so it throws ArgumentOutofRangeException.
        // -- Fix: "var value = _queue[1];" & "_queue.RemoveAt(1);" in "Dequeue" both need to have "0" instead of "1".

        Console.WriteLine("------------");

        // Test 2
        // Scenario: Enqueue multiple values and then Dequeue all of them
        // Expected Result: It should display 200, then 300, then 400 in that order
        Console.WriteLine("Test 2");
        queue = new SimpleQueue();
        queue.Enqueue(200);
        queue.Enqueue(300);
        queue.Enqueue(400);
        value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
        // Defect(s) Found:
        // -- 1. "Dequeue" method is trying to 1) find an item at index 1, then 2) remove that same item from index 1, but there is only one item in the queue so it throws ArgumentOutofRangeException.
        // -- 2. "Enqueue" method is adding an item at index 0 which is the front of the queue, but items must be added to the end of the queue.
        // -- Fix:
        // -- For #1: "var value = _queue[1];" & "_queue.RemoveAt(1);" in "Dequeue" both need to have "0" instead of "1".
        // -- For #2: "_queue.Insert(0, value)" in "Enqueue" should be changed to "_queue.Add(value)".

        Console.WriteLine("------------");

        // Test 3
        // Scenario: Dequeue from an empty Queue
        // Expected Result: An exception should be raised
        Console.WriteLine("Test 3");
        queue = new SimpleQueue();
        try {
            queue.Dequeue();
            Console.WriteLine("Oops ... This shouldn't have worked.");
        }
        catch (IndexOutOfRangeException) {
            Console.WriteLine("I got the exception as expected.");
        }
        // Defect(s) Found: None found
    }

    private readonly List<int> _queue = new();

    /// <summary>
    /// Enqueue the value provided into the queue
    /// </summary>
    /// <param name="value">Integer value to add to the queue</param>
    private void Enqueue(int value) {
        _queue.Add(value); // Fix: method changed to ".Add(value)"
    }

    /// <summary>
    /// Dequeue the next value and return it
    /// </summary>
    /// <exception cref="IndexOutOfRangeException">If queue is empty</exception>
    /// <returns>First integer in the queue</returns>
    private int Dequeue() {
        if (_queue.Count <= 0)
            throw new IndexOutOfRangeException();

        var value = _queue[0]; // Fix: index changed to 0
        _queue.RemoveAt(0); // Fix: index changed to 0
        return value;
    }
}