using System.Collections.Generic;
using FluentAssertions;
using OpeningMentor.Model.Pieces;
using OpeningMentor.Model.Primitives;
using Xunit;

namespace OpeningMentor.UnitTests.Pieces{
    public class QueenTests {
        
        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromD4()
        {
            Square piecePosition = new Square(File.D, 4);
            IPiece piece = new Queen();
            HashSet<Square> expected = new HashSet<Square>();
            //Horizontal/vertical squares
            expected.Add(new Square(File.D, 8));
            expected.Add(new Square(File.D, 7));
            expected.Add(new Square(File.D, 6));
            expected.Add(new Square(File.D, 5));
            expected.Add(new Square(File.D, 3));
            expected.Add(new Square(File.D, 2));
            expected.Add(new Square(File.D, 1));
            expected.Add(new Square(File.A, 4));
            expected.Add(new Square(File.B, 4));
            expected.Add(new Square(File.C, 4));
            expected.Add(new Square(File.E, 4));
            expected.Add(new Square(File.F, 4));
            expected.Add(new Square(File.G, 4));
            expected.Add(new Square(File.H, 4));
            //Diagonal squares
            expected.Add(new Square(File.A, 1));
            expected.Add(new Square(File.B, 2));
            expected.Add(new Square(File.C, 3));
            expected.Add(new Square(File.E, 5));
            expected.Add(new Square(File.F, 6));
            expected.Add(new Square(File.G, 7));
            expected.Add(new Square(File.H, 8));
            expected.Add(new Square(File.A, 7));
            expected.Add(new Square(File.B, 6));
            expected.Add(new Square(File.C, 5));
            expected.Add(new Square(File.E, 3));
            expected.Add(new Square(File.F, 2));
            expected.Add(new Square(File.G, 1));

            HashSet<Square> actual = piece.GetPossibleSquares(piecePosition);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}