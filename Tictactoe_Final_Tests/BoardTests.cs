using Tictactoe_Final;

namespace Tictactoe_Final_Tests;

public class BoardTests
{
    [Fact]
    public void Should_InitializeBoard_Empty()
    {
        var isEmpty = Board.IsEmpty();  // Assume we have a method to check if the board is empty.
    
        Assert.True(isEmpty);
    }
}