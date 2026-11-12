using ZChess.Attributes;
using ZChess.Enums;

namespace ZChess.Models
{
    [DataModel]
    public class PlayerColorModel
    {
        public int PlayerColorID { get; set; }
        public int GameInfoID { get; set; }
        public PlayerColorModel Player { get; set; }
        public eColor PlayerColor { get; set; }
    }
}
