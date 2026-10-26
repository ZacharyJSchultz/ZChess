namespace ZChess.Models
{
    public class BoardModel
    {
        public int BoardID { get; set; }
        public int GameID { get; set; }
        public List<TileModel> Tiles { get; set; }
        public GameStateModel GameState { get; set; }
    }
}
