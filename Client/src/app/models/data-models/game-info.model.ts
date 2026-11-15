import { PlayerColorModel } from './player-color.model'
import { TurnModel } from './turn.model'

export class GameInfoModel
{
    public gameInfoID: number;

    public gameID: number;

    public playerColors: PlayerColorModel[];

    public turnHistory: TurnModel[];

    constructor(opts?: Partial<GameInfoModel>) {
        Object.assign(this, opts);
    }

}
