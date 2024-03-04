public static class ArraysTester
{
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run()
    {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* Implementation Plan:
         * 1. Declare a fixed array 'multiples' with type 'double' with the length of the argument 'length'
         * 2. Create a 'for' loop with the following parameters:
         *     2a: declare variable 'i' with type 'int' & equal to 1
         *     2b: set range to 'i' less than or equal to 'length'
         *     2c: increment 'i' by one using '++' modifier
         * Inside the 'for' loop:
         * 3. call the 'multiples' array & attach '[i - 1]' to find the right index.
         *     The reason for subtraction is because 'i' starts at 1, but the array is zero indexed so the
         *      insertion index has to be one less than 'i' to account for zero index.
         * 4. Set 4's code equal to the formula 'number * i'.
         *     This multiplies 'number' by 'i''s current value, then stores the product into the 'multiples' array.
         *      This loop repeats until 'i' = 'length', then the last iteration runs, then the 'for' loop exits.
         * 5. Outside of & after the 'for' loop: return the 'multiples' list.
         * END OF 'MultiplesOf' function --------------------------------
        */

        double[] multiples = new double[length];
        for (int i = 1; i <= length; i++)
        {
            multiples[i - 1] = number * i;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* Implementation Plan:
         * 1. Declare the exterior for-loop:
         *     1a: declare variable 'i1' with type 'int' & equal to 1
         *     1b: set range to 'i1' less than or equal to 'amount'
         *     1c: increment 'i1' by one using '++' modifier
         *    -- This loop will run the interior for-loop 'amount' times
         * 2. Declare the interior for-loop:
         *     2a: declare variable 'i2' with type 'int' & equal to the count of 'data' list
         *     2b: set range to 'i2' greater than 0
         *     2c: decrement 'i2' by one using '--' modifier
         *    -- This loop will iterate through every item within 'data',
         *        moving the current item one to the left, which in turn
         *        moves each other item one to the right
         * 5. Declare variable 'newIndex' with type 'int'  & equal to 'i2 - 1'
         *    -- This will find the next index the current item needs to be moved to.
         * 6. Declare variable 'item' with type 'var'  & equal to 'i2 - 1'
         *    -- This will find the next index the current item needs to be moved to.
         * 7a. call the 'data' list & set the index as 'newIndex'
         * 7b: type '=', then call the 'data' list & set the index as 'i2'
         *     -- This overwrites the value at 'data[newIndex]' with the value
         *        of 'data[i2]'
         * 8. call the 'data' list and set the index as 'i2', then set it equal to 'item'
            -- This will overwrite the value at 'data[i2]' with the value of 'item'
         * END OF 'RotateListRight' function --------------------------------
        */

        // ----------------Implementation----------------------
        // Run the interior for-loop as many times as 'amount' equals
        for (int i1 = 1; i1 <= amount; i1++)
        {
            /* Interior for-loop Explanation:
             * -Start at the final index & move that value one to the left,
             *   then repeat until the original 'finalIndex''s value is at index zero.
             * -This shifts everything one spot to the right. The exterior for-loop repeats
             *   this interior for-loop according to 'amount'.
             * -This ensures everything is moved the exact amount to the right.
             * -Loop starts with the last item in the array & moves backwards
             *   through the array until it gets to the first item
            */

            for (int i2 = data.Count - 1; i2 > 0; i2--)
            {
                // find the next index the current item needs to be moved to.
                int newIndex = i2 - 1;
                // value at newIndex is saved into variable 'item'
                var item = data[newIndex];
                // value at newIndex is overwritten by value at current index
                data[newIndex] = data[i2];
                // value at current index is replaced by 'item'
                data[i2] = item;
            }
        }

    }
}
