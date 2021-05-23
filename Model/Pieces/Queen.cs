using System.Collections.Generic;
using OpeningMentor.Model.Primitives;

namespace OpeningMentor.Model.Pieces{
    public class Queen : IPiece
    {
        private HashSet<(int, int)> movementDirections = new HashSet<(int, int)> { (1, 0), (1, 1), (0, 1), (-1, 1), (-1, 0), (-1, -1), (0, -1), (1, -1) };
        
        public HashSet<Square> GetPossibleSquares(Square square)
        {
            HashSet<Square> possibleSquares = new HashSet<Square>();
            foreach((int fileDirection, int rankDirection) in movementDirections){
                Square targetSquare = new Square(square.file + (1 * fileDirection), square.rank + (1 * rankDirection));
                while ((int)targetSquare.file > 0 && (int)targetSquare.file < 9 && targetSquare.rank > 0 && targetSquare.rank < 9){
                    possibleSquares.Add(targetSquare);
                    targetSquare = new Square(targetSquare.file + (1 * fileDirection), targetSquare.rank + (1 * rankDirection));
                }
            }
            return possibleSquares;
        }
    }
}