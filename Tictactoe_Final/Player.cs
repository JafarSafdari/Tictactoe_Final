namespace Tictactoe_Final;

public class Player
{
    public string Name { get; set; }
    public char Marker { get; set; }

    public Player(string name, char marker)
    {
        Name = name;
        Marker = marker;
    }

    public void MakeRandomMove(Board board)
    {
        Random rnd = new Random();
        int row, col;
        do
        {
            row = rnd.Next(0, 3);
            col = rnd.Next(0, 3);
        }
        while (board.GetCell(row, col) != ' ');  
        
        board.PlaceMarker(row, col, Marker);
    }
}
