using System.Collections.Generic;
using OpeningMentor.Model.Primitives;

namespace OpeningMentor.Model.Pieces {
    public interface IPiece {

        HashSet<Square> GetPossibleSquares(Square square);
    }
}