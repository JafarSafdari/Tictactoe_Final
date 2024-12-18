namespace Tictactoe_Final;

public class Game
{
    public char CurrentTurn { get; private set; } = 'X';  

    public void MakeMove(int row, int col)
    {
     
        CurrentTurn = CurrentTurn == 'X' ? 'O' : 'X';
    }

    public string CheckWinner(Board board)
    {
        throw new NotImplementedException();
    }
}