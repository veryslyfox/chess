class Field
{
    public Field(Square[,] squares)
    {
        Squares = squares;
    }

    public Square[,] Squares { get; }
    public Square this[int x, int y] { get => Squares[x, y]; set => Squares[x, y] = value; }
    public static Field StartPosition()
    {
        var res = new Field(new Square[8, 8]);
        res.Squares[0, 0] = (Square)1;
        res[0, 0] = (Square)4;
        res[0, 1] = (Square)5;
        res[0, 2] = (Square)3;
        res[0, 3] = (Square)6;
        res[0, 4] = (Square)1;
        res[0, 5] = (Square)3;
        res[0, 6] = (Square)5;
        res[0, 7] = (Square)4;
        res[1, 0] = (Square)2;
        res[1, 1] = (Square)2;
        res[1, 2] = (Square)2;
        res[1, 3] = (Square)2;
        res[1, 4] = (Square)2;
        res[1, 5] = (Square)2;
        res[1, 6] = (Square)2;
        res[1, 7] = (Square)2;
        res[2, 0] = (Square)0;
        res[2, 1] = (Square)0;
        res[2, 2] = (Square)0;
        res[2, 3] = (Square)0;
        res[2, 4] = (Square)0;
        res[2, 5] = (Square)0;
        res[2, 6] = (Square)0;
        res[2, 7] = (Square)0;
        res[3, 0] = (Square)0;
        res[3, 1] = (Square)0;
        res[3, 2] = (Square)0;
        res[3, 3] = (Square)0;
        res[3, 4] = (Square)0;
        res[3, 5] = (Square)0;
        res[3, 6] = (Square)0;
        res[3, 7] = (Square)0;
        res[4, 0] = (Square)0;
        res[4, 1] = (Square)0;
        res[4, 2] = (Square)0;
        res[4, 3] = (Square)0;
        res[4, 4] = (Square)0;
        res[4, 5] = (Square)0;
        res[4, 6] = (Square)0;
        res[4, 7] = (Square)0;
        res[5, 0] = (Square)0;
        res[5, 1] = (Square)0;
        res[5, 2] = (Square)0;
        res[5, 3] = (Square)0;
        res[5, 4] = (Square)0;
        res[5, 5] = (Square)0;
        res[5, 6] = (Square)0;
        res[5, 7] = (Square)0;
        res[6, 0] = (Square)8;
        res[6, 1] = (Square)8;
        res[6, 2] = (Square)8;
        res[6, 3] = (Square)8;
        res[6, 4] = (Square)8;
        res[6, 5] = (Square)8;
        res[6, 6] = (Square)8;
        res[6, 7] = (Square)8;
        res[7, 0] = (Square)10;
        res[7, 1] = (Square)11;
        res[7, 2] = (Square)9;
        res[7, 3] = (Square)12;
        res[7, 4] = (Square)7;
        res[7, 5] = (Square)9;
        res[7, 6] = (Square)11;
        res[7, 7] = (Square)10;
        return res;
    }
}