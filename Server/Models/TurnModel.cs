using ZChess.Enums;

namespace ZChess.Models
{
    public class TurnModel
    {
        public int TurnID { get; set; }
        public int GameInfoID { get; set; }
        public int TurnOrder { get; set; }
        public PlayerModel Player { get; set; }
        public eColor PlayerColor { get; set; }
        public MoveModel Move { get; set; }
    }
}
