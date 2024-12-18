namespace Tictactoe_Final
{
    public class Board
    {
        private char[,] cells = new char[3, 3];

        public Board()  
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = ' '; 
                }
            }
        }

        public bool IsEmpty()
        {
            foreach (var cell in cells)
            {
                if (cell != ' ') 
                    return false;
            }
            return true;
        }

        public void PlaceMarker(int row, int col, char marker)
        {
            if (cells[row, col] == ' ')  
            {
                cells[row, col] = marker;
            }
        }

        public char GetCell(int row, int col)
        {
            return cells[row, col];
        }
    }
}