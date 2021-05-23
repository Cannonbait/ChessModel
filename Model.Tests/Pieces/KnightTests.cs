using System.Collections.Generic;
using FluentAssertions;
using OpeningMentor.Model.Pieces;
using OpeningMentor.Model.Primitives;
using Xunit;

namespace OpeningMentor.UnitTests.Pieces{
    public class KnightTests {
        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromD4()
        {
            Square piecePosition = new Square(File.D, 4);
            IPiece piece = new Knight();
            HashSet<Square> expected = new HashSet<Square>();
            expected.Add(new Square(File.F, 5));
            expected.Add(new Square(File.E, 6));
            expected.Add(new Square(File.C, 6));
            expected.Add(new Square(File.B, 5));
            expected.Add(new Square(File.B, 3));
            expected.Add(new Square(File.C, 2));
            expected.Add(new Square(File.E, 2));
            expected.Add(new Square(File.F, 3));
            HashSet<Square> actual = piece.GetPossibleSquares(piecePosition);
            actual.Should().BeEquivalentTo(expected);
        }
    }

}