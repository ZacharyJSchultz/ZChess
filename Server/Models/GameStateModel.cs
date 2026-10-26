using ZChess.Models.Pieces;

namespace ZChess.Models
{
    public class GameStateModel
    {
        public int GameStateID { get; set; }
        public int BoardID { get; set; }
        public List<BasePieceModel> CapturedWhitePieces { get; set; }
        public List<BasePieceModel> CapturedBlackPieces { get; set; }
        public TileModel SelectedTile { get; set; }
        public TurnModel CurrentTurn { get; set; }
        public PlayerModel? PlayerInCheck { get; set; }
    }
}
