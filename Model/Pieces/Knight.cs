using System.Collections.Generic;
using OpeningMentor.Model.Primitives;

namespace OpeningMentor.Model.Pieces{
    public class Knight : IPiece
    {
        private HashSet<(int, int)> movementDirections = new HashSet<(int, int)> { (2, 1), (1, 2), (-1, 2), (-2, 1), (-2, -1), (-1, -2), (1, -2), (2, -1) };
        public HashSet<Square> GetPossibleSquares(Square square)
        {            
            HashSet<Square> possibleSquares = new HashSet<Square>();
            foreach((int fileDirection, int rankDirection) in movementDirections){
                Square targetSquare = new Square(square.file + (1 * fileDirection), square.rank + (1 * rankDirection));
                if ((int)targetSquare.file > 0 && (int)targetSquare.file < 9 && targetSquare.rank > 0 && targetSquare.rank < 9){
                    possibleSquares.Add(targetSquare);
                }
            }
            return possibleSquares;
        }
    }
}