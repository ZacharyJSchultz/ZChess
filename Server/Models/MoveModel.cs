using ZChess.Models.Pieces;

namespace ZChess.Models
{
    public class MoveModel
    {
        public int MoveID { get; set; }
        public int TurnID { get; set; }
        public BasePieceModel Piece { get; set; }
        public TileModel OldTile { get; set; }
        public TileModel NewTile { get; set; }
        public BasePieceModel? CapturedPiece { get; set; }
        public string Notation { get; set; }
    }
}
