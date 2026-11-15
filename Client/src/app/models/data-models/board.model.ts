import { TileModel } from './tile.model'
import { GameStateModel } from './game-state.model'

export class BoardModel
{
    public boardID: number;

    public gameID: number;

    public tiles: TileModel[];

    public gameState: GameStateModel;

    constructor(opts?: Partial<BoardModel>) {
        Object.assign(this, opts);
    }

}
