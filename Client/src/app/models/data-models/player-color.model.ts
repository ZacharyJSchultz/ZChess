import { eColor } from './color.enum'

export class PlayerColorModel
{
    public playerColorID: number;

    public gameInfoID: number;

    public player: PlayerColorModel;

    public playerColor: eColor;

    constructor(opts?: Partial<PlayerColorModel>) {
        Object.assign(this, opts);
    }

}
