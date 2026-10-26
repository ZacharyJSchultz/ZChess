namespace ZChess.Models
{
    public class GameInfoModel
    {
        public int GameInfoID { get; set; }
        public int GameID { get; set; }
        public List<PlayerColorModel> PlayerColors { get; set; }
        public List<TurnModel> TurnHistory { get; set; }
    }
}
