static class Movement
{
    public static bool CheckNoObjects(RelativeIndexer indexer, int x, int y, int length)
    {
        var result = true;
        for (int i = 1; i < length; i++)
        {
            result &= indexer[x * i / length, y * i / length] == Square.EmptySquare;
        }
        return result;
    }
    public static bool IsPossible(int xMovement, int yMovement, int x, int y, RelativeIndexer indexer)
    {
        
    }
}