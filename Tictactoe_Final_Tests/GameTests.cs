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
}