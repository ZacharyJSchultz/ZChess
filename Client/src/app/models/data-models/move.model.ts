import { BasePieceModel } from './base-piece.model'
import { TileModel } from './tile.model'
import { TileModel } from './tile.model'
import { BasePieceModel } from './base-piece.model'

export class MoveModel
{
    public moveID: number;

    public turnID: number;

    public piece: BasePieceModel;

    public oldTile: TileModel;

    public newTile: TileModel;

    public capturedPiece: BasePieceModel | null;

    public notation: string;

    constructor(opts?: Partial<MoveModel>) {
        Object.assign(this, opts);
    }

}
