struct RelativeIndexer
{
    public RelativeIndexer(Board board, int shiftX, int shiftY)
    {
        Board = board;
        ShiftX = shiftX;
        ShiftY = shiftY;
    }

    public Board Board { get; }
    public int ShiftX { get; }
    public int ShiftY { get; }
    public Square this[int x, int y] { get => Board[x + ShiftX, y + ShiftY]; }
}