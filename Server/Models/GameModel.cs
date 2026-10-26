namespace ZChess.Models
{
    public class GameModel
    {
        public int GameID { get; set; }
        public BoardModel Board { get; set; }
        public GameInfoModel GameInfo { get; set; }
        public List<PlayerModel> Players { get; set; }
    }
}
