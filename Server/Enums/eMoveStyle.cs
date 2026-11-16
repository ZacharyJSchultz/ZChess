using ZChess.Attributes;

namespace ZChess.Enums
{
    [SharedEnum]
    public enum eMoveStyle
    {
        NotSet = 0,
        Pawn = 1,
        Rook = 2,
        Knight = 3,
        Bishop = 4,
        Queen = 5,
        King = 6,
    }
}
