using ZChess.Attributes;

namespace ZChess.Models
{
    [DataModel]
    public class PlayerModel
    {
        public int PlayerID { get; set; }
        public string UserName { get; set; }
        public List<GameModel> GameHistory { get; set; }
    }
}
