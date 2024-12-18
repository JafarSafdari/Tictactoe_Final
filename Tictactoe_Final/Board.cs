﻿namespace Tictactoe_Final
{
    public static class Board
    {
        private static char[,] cells = new char[3, 3];
        
        static Board()  
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = ' '; 
                }
            }
        }

        public static bool IsEmpty()
        {
            foreach (var cell in cells)
            {
                if (cell != ' ') 
                    return false;
            }
            return true;
        }

        public static void PlaceMarker(int i, int i1, char c)
        {
            throw new NotImplementedException();
        }

        public static char GetCell(int i, int i1)
        {
            throw new NotImplementedException();
        }
    }
}