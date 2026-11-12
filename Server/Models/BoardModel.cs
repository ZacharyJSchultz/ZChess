using ZChess.Attributes;

namespace ZChess.Models
{
    [DataModel]
    public class BoardModel
    {
        public int BoardID { get; set; }
        public int GameID { get; set; }
        public List<TileModel> Tiles { get; set; }
        public GameStateModel GameState { get; set; }
    }
}
