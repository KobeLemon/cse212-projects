/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if the desired direction is a wall or not
    /// If not, return false
    /// If yes, return true
    /// </summary>
    private bool CheckIfWallExists(int desiredX, int desiredY)
    {

        int minX = 1;
        int maxX = 6;

        int minY = 1;
        int maxY = 6;

        /// If desiredX or desiredY are not between min & max,
        ///   that is out of bounds so return false
        if (
            (desiredX < minX || desiredX > maxX)
            ||
            (desiredY < minY || desiredY > maxY)
            ) { return true; }

        /// The keys in this dictionary are the x coordinate, values are the y coordinate
        /// Any coordinate pair found in this dictionary (ex. 1,3) is a wall
        /// Any coordinate pair NOT found in this dictionary (ex. 1,2) is an open space
        Dictionary<int, HashSet<int>> walls = new Dictionary<int, HashSet<int>>
        {
            {1, new HashSet<int> { 3 }},
            {2 , new HashSet<int> { 5, 6 } },
            {3 , new HashSet<int> { 1, 2, 3 }},
            {4 , new HashSet<int> { 2, 5 }},
            {5 , new HashSet<int> {  }},
            {6 , new HashSet<int> { 2, 4, 5 }}
        };

        /// if walls contains both the desiredX & desiredY,
        ///   they are trying to move into a wall so return true
        var item = walls[desiredX];
        if (walls[desiredX].Contains(desiredY)) { return true; }

        /// if all 'if-statments' are false, there is no wall so return false
        /// Conditions:
        ///   1) desiredX & desiredY are each w/n min & max.
        ///   2) walls dict does not have a wall at the desired coords.
        return false;
    }

    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft()
    {
        /// Move X by one position to the left.
        /// This is done be decrementing X & leaving Y alone.
        if (CheckIfWallExists(_currX - 1, _currY))
        {
            /// Keep for Production:
            Console.WriteLine("Can't go that way!");

            // Console.WriteLine("Can't move to the left"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine($"Desired Location: (x={_currX - 1}, y={_currY})\n"); /// Uncomment for testing
        } else {
            // Console.WriteLine($"Old location (x={_currX}, y={_currY})"); /// Uncomment for testing

            /// Keep for production:
            _currX--;

            // Console.WriteLine("Successfully moved left"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine("\n"); /// Uncomment for testing
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight()
    {
        /// Move X by one position to the right.
        /// This is done be incrementing X & leaving Y alone.
        if (CheckIfWallExists(_currX + 1, _currY))
        {
            /// Keep for Production:
            Console.WriteLine("Can't go that way!");

            // Console.WriteLine("Can't move to the right"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine($"Desired Location: (x={_currX}, y={_currY})\n"); /// Uncomment for testing
        } else {
            // Console.WriteLine($"Old location (x={_currX}, y={_currY})"); /// Uncomment for testing

            /// Keep for production:
            _currX++;

            // Console.WriteLine("Successfully moved right"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine("\n"); /// Uncomment for testing
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp()
    {
        /// Move Y by one position up.
        /// This is done be decrementing Y & leaving X alone.
        if (CheckIfWallExists(_currX, _currY - 1))
        {
            /// Keep for Production:
            Console.WriteLine("Can't go that way!");

            // Console.WriteLine("Can't move up"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine($"Desired Location: (x={_currX}, y={_currY})\n"); /// Uncomment for testing
        } else {
            // Console.WriteLine($"Old location (x={_currX}, y={_currY})"); /// Uncomment for testing

            /// Keep for production:
            _currY--;

            // Console.WriteLine("Successfully moved up"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine(""); /// Uncomment for testing
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown()
    {
        /// Move Y by one position down.
        /// This is done be incrementing Y & leaving X alone.
        if (CheckIfWallExists(_currX, _currY + 1))
        {
            /// Keep for Production:
            Console.WriteLine("Can't go that way!");

            // Console.WriteLine("Can't move down"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine($"Desired Location: (x={_currX}, y={_currY})\n"); /// Uncomment for testing

        } else {
            // Console.WriteLine($"Old location (x={_currX}, y={_currY})"); /// Uncomment for testing

            /// Keep for production:
            _currY++;

            // Console.WriteLine("Successfully moved down"); /// Uncomment for testing
            // ShowStatus(); /// Uncomment for testing
            // Console.WriteLine("\n"); /// Uncomment for testing
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}