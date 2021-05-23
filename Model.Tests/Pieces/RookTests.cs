using Xunit;
using OpeningMentor.Model.Pieces;
using OpeningMentor.Model.Primitives;
using System.Collections.Generic;
using System;
using FluentAssertions;

namespace OpeningMentor.UnitTests.Pieces
{
    public class RookTests
    {
        
        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromD4()
        {
            Square piecePosition = new Square(File.D, 4);
            IPiece piece = new Rook();
            HashSet<Square> expected = new HashSet<Square>();
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

            HashSet<Square> actual = piece.GetPossibleSquares(piecePosition);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}