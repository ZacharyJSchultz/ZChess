export class GameStateModel
{
    public gameStateID: number;

    public boardID: number;

    public capturedWhitePieces: BasePieceModel[];

    public capturedBlackPieces: BasePieceModel[];

    public selectedTile: TileModel;

    public currentTurn: TurnModel;

    public playerInCheck: PlayerModel | null;
}
