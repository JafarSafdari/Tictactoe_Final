namespace Tictactoe_Final;

public static class Board
{
    private static char[,] cells = new char[3, 3];
    
    public static bool IsEmpty()
    {
        foreach (var cell in cells)
        {
            if (cell != ' ') // If any cell is not empty
                return false;
        }
        return true;
    }
}