namespace Tictactoe_Final;

public class Game
{
    public char CurrentTurn { get; private set; } = 'X';
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }

    public void MakeMove(int row, int col)
    {
     
        CurrentTurn = CurrentTurn == 'X' ? 'O' : 'X';
    }

    public string CheckWinner(Board board)
    {
        if (board.GetCell(0, 0) == board.GetCell(0, 1) && board.GetCell(0, 1) == board.GetCell(0, 2) && board.GetCell(0, 0) != ' ')
        {
            return board.GetCell(0, 0).ToString();
        }
        return null;
    }

    public void StartGame()
    {
        throw new NotImplementedException();
    }
}