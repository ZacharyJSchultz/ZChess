import { BasePieceModel } from './base-piece.model'
import { BasePieceModel } from './base-piece.model'
import { TileModel } from './tile.model'
import { TurnModel } from './turn.model'
import { PlayerModel } from './player.model'

export class GameStateModel
{
    public gameStateID: number;

    public boardID: number;

    public capturedWhitePieces: BasePieceModel[];

    public capturedBlackPieces: BasePieceModel[];

    public selectedTile: TileModel;

    public currentTurn: TurnModel;

    public playerInCheck: PlayerModel | null;

    constructor(opts?: Partial<GameStateModel>) {
        Object.assign(this, opts);
    }

}
