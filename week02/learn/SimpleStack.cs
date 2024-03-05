using System;
using System.Collections;
using System.Collections.Generic;

public class SimpleStack {
    public static void Run() {
        var stack = new Stack(); // Empty Stack -- {}
        stack.Push(1); // Add '1' to the back of the stack -- { 1 }
        Console.WriteLine($"\nstack.Push(1):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(2); // Add '2' to the back of the stack -- { 2, 1 }
        Console.WriteLine($"\nstack.Push(2):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(3); // Add '3' to the back of the stack -- { 3, 2, 1 }
        Console.WriteLine($"\nstack.Push(3):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        var popped = stack.Pop(); // Remove the last item '3' from the back of the stack -- { 2, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '2' from the back of the stack -- { 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(4); // Add '4' to the back of the stack -- { 4, 1 }
        Console.WriteLine($"\nstack.Push(4):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(5); // Add '5' to the back of the stack -- { 5, 4, 1 }
        Console.WriteLine($"\nstack.Push(5):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '5' from the back of the stack -- { 4, 1 }
        Console.WriteLine($"\nstack.Pop() - 5:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(6); // Add '6' to the back of the stack -- { 6, 4, 1 }
        Console.WriteLine($"\nstack.Push(6):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(7); // Add '7' to the back of the stack -- { 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Push(7):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(8); // Add '8' to the back of the stack -- { 8, 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Push(8):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(9); // Add '9' to the back of the stack -- { 9, 8, 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Push(9):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '9' from the back of the stack -- { 8, 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '8' from the back of the stack -- { 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(10); // Add '10' to the back of the stack -- { 10, 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Push(10):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '10' from the back of the stack -- { 7, 6, 4, 1 }
        Console.WriteLine($"\nstack.Pop() - 10:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '7' from the back of the stack -- { 6, 4, 1 }
        Console.WriteLine($"\nstack.Pop() - 7:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '6' from the back of the stack -- { 4, 1 }
        Console.WriteLine($"\nstack.Pop() - 6:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(11); // Add '11' to the back of the stack -- { 11, 4, 1 }
        Console.WriteLine($"\nstack.Push(11):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(12); // Add '12' to the back of the stack -- { 12, 11, 4, 1 }
        Console.WriteLine($"\nstack.Push(12):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '12' from the back of the stack -- { 11, 4, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '11' from the back of the stack -- { 4, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '4' from the back of the stack -- { 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(13); // Add '13' to the back of the stack -- { 13, 1 }
        Console.WriteLine($"\nstack.Push(13):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(14); // Add '14' to the back of the stack -- { 14, 13, 1 }
        Console.WriteLine($"\nstack.Push(14):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(15); // Add '15' to the back of the stack -- { 15, 14, 13, 1 }
        Console.WriteLine($"\nstack.Push(15):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(16); // Add '16' to the back of the stack -- { 16, 15, 14, 13, 1 }
        Console.WriteLine($"\nstack.Push(16):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '16' from the back of the stack -- { 15, 14, 13, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '15' from the back of the stack -- { 14, 13, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '14' from the back of the stack -- { 13, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(17); // Add '17' to the back of the stack -- { 17, 13, 1 }
        Console.WriteLine($"\nstack.Push(17):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(18); // Add '18' to the back of the stack -- { 18, 17, 13, 1 }
        Console.WriteLine($"\nstack.Push(18):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '18' from the back of the stack -- { 17, 13, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(19); // Add '19' to the back of the stack -- { 19, 17, 13, 1 }
        Console.WriteLine($"\nstack.Push(19):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        stack.Push(20); // Add '20' to the back of the stack -- { 20, 19, 17, 13, 1 }
        Console.WriteLine($"\nstack.Push(20):");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '20' from the back of the stack -- { 19, 17, 13, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));

        popped = stack.Pop(); // Remove the last item '19' from the back of the stack -- { 17, 13, 1 }
        Console.WriteLine($"\nstack.Pop(): - {popped}");
        Console.WriteLine(String.Join(", ", stack.ToArray()));


        Console.WriteLine($"\nFinal contents:"); // { 17, 13, 1 }
        Console.WriteLine(String.Join(", ", stack.ToArray())); // "17, 13, 1"
    }
}
