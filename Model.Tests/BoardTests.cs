using FluentAssertions;
using OpeningMentor.Model;
using Xunit;

namespace OpeningMentor.UnitTests{
    public class BoardTests{

        [Fact]
        public void TestBlankInitialisation(){
            Board board = new Board();
            board.getFen().Should().Be("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
        }
    }
}