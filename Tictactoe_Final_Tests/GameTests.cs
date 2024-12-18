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
        Assert.Equal("X", winner);  
    }
    
    [Fact]
    public void Should_InitializeGame_WithTwoBots()
    {
        var game = new Game();
        game.StartGame();  

        var player1 = game.Player1;
        var player2 = game.Player2;

        Assert.NotNull(player1);
        Assert.NotNull(player2);
        Assert.NotEqual(player1.Name, player2.Name); 
    }
    
    [Fact]
    public void Should_MakeRandomMove_WhenBotPlays()
    {
        var game = new Game();
        game.StartGame();

        var initialMove = game.Board.GetCell(0, 0);  

        game.Player1.MakeRandomMove(game.Board);
        
        var newMove = game.Board.GetCell(0, 0);
        
        Assert.NotEqual(initialMove, newMove);
    }
}