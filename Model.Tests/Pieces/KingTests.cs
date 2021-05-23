using System.Collections.Generic;
using FluentAssertions;
using OpeningMentor.Model.Pieces;
using OpeningMentor.Model.Primitives;
using Xunit;

namespace OpeningMentor.UnitTests.Pieces{
    public class KingTests {
        
        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromD4()
        {
            Square piecePosition = new Square(File.D, 4);
            IPiece piece = new King();
            HashSet<Square> expected = new HashSet<Square>();
            expected.Add(new Square(File.E, 4));
            expected.Add(new Square(File.E, 5));
            expected.Add(new Square(File.D, 5));
            expected.Add(new Square(File.C, 5));
            expected.Add(new Square(File.C, 4));
            expected.Add(new Square(File.C, 3));
            expected.Add(new Square(File.D, 3));
            expected.Add(new Square(File.E, 3));
            HashSet<Square> actual = piece.GetPossibleSquares(piecePosition);
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromA1()
        {
            Square piecePosition = new Square(File.A, 1);
            IPiece piece = new King();
            HashSet<Square> expected = new HashSet<Square>();
            expected.Add(new Square(File.A, 2));
            expected.Add(new Square(File.B, 2));
            expected.Add(new Square(File.B, 1));
            HashSet<Square> actual = piece.GetPossibleSquares(piecePosition);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}