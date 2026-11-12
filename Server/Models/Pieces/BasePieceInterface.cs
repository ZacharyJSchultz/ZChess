using ZChess.Attributes;
using ZChess.Enums;

namespace ZChess.Models.Pieces
{
    [DataModel]
    public class BasePieceModel
    {
        public int PieceID { get; set; }
        public eMoveStyle MoveStyle { get; set; }
        public eColor PlayerColor { get; set; }
        public TileModel CurrentTile { get; set; }
    }
}
