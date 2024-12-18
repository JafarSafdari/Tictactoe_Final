using Tictactoe_Final;

namespace Tictactoe_Final_Tests
{
    public class BoardTests
    {
        [Fact]
        public void Should_InitializeBoard_Empty()
        {
            var board = new Board(); 
            var isEmpty = board.IsEmpty(); 
    
            Assert.True(isEmpty);
        }
    
        [Fact]
        public void Should_PlaceMarker_InEmptyCell()
        {
            var board = new Board();
            board.PlaceMarker(0, 0, 'X');  
        
            Assert.Equal('X', board.GetCell(0, 0)); 
        }
    
        [Fact]
        public void Should_NotPlaceMarker_InOccupiedCell()
        {
            var board = new Board(); 
            board.PlaceMarker(0, 0, 'X');  
            board.PlaceMarker(0, 0, 'O');  

            Assert.Equal('X', board.GetCell(0, 0));  
        }
    }
}