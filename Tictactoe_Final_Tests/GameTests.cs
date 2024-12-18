using Tictactoe_Final;

namespace Tictactoe_Final_Tests;

public class GameTests
{
    [Fact]
    public void Should_SwitchTurn_AfterEachMove()
    {
        var game = new Game();  
        char currentTurn = game.CurrentTurn;  

        game.MakeMove(0, 0);  
        Assert.NotEqual(currentTurn, game.CurrentTurn);  
    }
    
    [Fact]
    public void Should_ReturnWinner_AfterThreeInRow()
    {
        var game = new Game();
        var board = new Board();
    
        board.PlaceMarker(0, 0, 'X');
        board.PlaceMarker(0, 1, 'X');
        board.PlaceMarker(0, 2, 'X'); 
    
        string winner = game.CheckWinner(board);  
        Assert.Equal("X", winner);  // 'X' should win
    }
}