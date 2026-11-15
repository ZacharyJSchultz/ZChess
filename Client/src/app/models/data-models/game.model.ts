import { BoardModel } from './board.model'
import { GameInfoModel } from './game-info.model'
import { PlayerModel } from './player.model'

export class GameModel
{
    public gameID: number;

    public board: BoardModel;

    public gameInfo: GameInfoModel;

    public players: PlayerModel[];

    constructor(opts?: Partial<GameModel>) {
        Object.assign(this, opts);
    }

}
