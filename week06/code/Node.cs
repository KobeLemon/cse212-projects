public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            Console.WriteLine($"{value} is already in the list");
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
            {
                Left = new Node(value);
            }
            else
            {
                Left.Insert(value);
            }
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            // Data = Left.Data;
            if (Left != null)
            {
                return Left.Contains(value);
            }
            else { return false; }
        }
        else
        {
            // Data = Right.Data;
            if (Right != null)
            {
                return Right.Contains(value);
            }
            else { return false; }
        }
    }

    public int GetHeight(int size = 0)
    {
        size++;

        int leftHeight = 0;
        int rightHeight = 0;

        if (Left == null && Right == null)
        {
            return size;
        }

        if (Left != null)
        {
            leftHeight = Left.GetHeight(size);
        }

        if (Right != null)
        {
            rightHeight = Right.GetHeight(size);
        }

        if (leftHeight >= rightHeight)
        {
            return leftHeight;
        }
        else
        {
            return rightHeight;
        }

    }
}