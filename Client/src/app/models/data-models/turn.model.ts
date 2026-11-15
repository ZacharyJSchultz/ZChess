import { PlayerModel } from './player.model'
import { eColor } from './color.enum'
import { MoveModel } from './move.model'

export class TurnModel
{
    public turnID: number;

    public gameInfoID: number;

    public turnOrder: number;

    public player: PlayerModel;

    public playerColor: eColor;

    public move: MoveModel;

    constructor(opts?: Partial<TurnModel>) {
        Object.assign(this, opts);
    }

}
