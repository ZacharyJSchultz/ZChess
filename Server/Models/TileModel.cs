using ZChess.Enums;
using ZChess.Models.Pieces;

namespace ZChess.Models
{
    public class TileModel
    {
        public int TileID { get; set; }
        public BasePieceModel CurrentPiece { get; set; }
        public eTileColor Color { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
