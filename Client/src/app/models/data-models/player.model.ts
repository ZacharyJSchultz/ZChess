import { GameModel } from './game.model'

export class PlayerModel
{
    public playerID: number;

    public userName: string;

    public gameHistory: GameModel[];

    constructor(opts?: Partial<PlayerModel>) {
        Object.assign(this, opts);
    }

}
