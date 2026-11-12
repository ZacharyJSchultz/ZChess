export class MoveModel
{
    public moveID: number;

    public turnID: number;

    public piece: BasePieceModel;

    public oldTile: TileModel;

    public newTile: TileModel;

    public capturedPiece: BasePieceModel | null;

    public notation: string;
}
