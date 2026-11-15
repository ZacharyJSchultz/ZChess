import { BasePieceModel } from './base-piece.model'
import { eTileColor } from './tile-color.enum'

export class TileModel
{
    public tileID: number;

    public currentPiece: BasePieceModel;

    public color: eTileColor;

    public row: number;

    public col: number;

    constructor(opts?: Partial<TileModel>) {
        Object.assign(this, opts);
    }

}
