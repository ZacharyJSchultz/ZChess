import { eMoveStyle } from '../move-style.enum'
import { eColor } from '../color.enum'
import { TileModel } from '../tile.model'

export class BasePieceModel
{
    public pieceID: number;

    public moveStyle: eMoveStyle;

    public playerColor: eColor;

    public currentTile: TileModel;

    constructor(opts?: Partial<BasePieceModel>) {
        Object.assign(this, opts);
    }

}
