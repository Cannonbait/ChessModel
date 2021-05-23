using System;
using System.Collections.Generic;
using FluentAssertions;
using OpeningMentor.Model.Pieces;
using OpeningMentor.Model.Primitives;
using Xunit;

namespace OpeningMentor.UnitTests.Pieces{
    public class BishopTests{
        
        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromE4()
        {
            Square piecePosition = new Square(File.E, 4);
            IPiece piece = new Bishop();
            HashSet<Square> expected = new HashSet<Square>();
            expected.Add(new Square(File.B, 1));
            expected.Add(new Square(File.C, 2));
            expected.Add(new Square(File.D, 3));
            expected.Add(new Square(File.F, 5));
            expected.Add(new Square(File.G, 6));
            expected.Add(new Square(File.H, 7));
            expected.Add(new Square(File.A, 8));
            expected.Add(new Square(File.B, 7));
            expected.Add(new Square(File.C, 6));
            expected.Add(new Square(File.D, 5));
            expected.Add(new Square(File.F, 3));
            expected.Add(new Square(File.G, 2));
            expected.Add(new Square(File.H, 1));

            HashSet<Square> actual = piece.GetPossibleSquares(piecePosition);
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void EmptyBoard_GetPossibleSquares_FromD4()
        {
            Square piecePosition = new Square(File.D, 4);
            IPiece piece = new Bishop();
            HashSet<Square> expected = new HashSet<Square>();
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