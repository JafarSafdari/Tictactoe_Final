using Tictactoe_Final;

namespace Tictactoe_Final_Tests;

public class BoardTests
{
    [Fact]
    public void Should_InitializeBoard_Empty()
    {
        var isEmpty = Board.IsEmpty(); 
    
        Assert.True(isEmpty);
    }
    
    [Fact]
    public void Should_PlaceMarker_InEmptyCell()
    {
        Board.PlaceMarker(0, 0, 'X');  
        
        Assert.Equal('X', Board.GetCell(0, 0)); 
    }
    
    [Fact]
    public void Should_NotPlaceMarker_InOccupiedCell()
    {
        Board.PlaceMarker(0, 0, 'X');  
        Board.PlaceMarker(0, 0, 'O');  

        Assert.Equal('X', Board.GetCell(0, 0));  
    }
}