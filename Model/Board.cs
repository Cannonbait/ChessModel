using System.Collections.Generic;
using OpeningMentor.Model.Pieces;

namespace OpeningMentor.Model{
    public class Board {

        public HashSet<IPiece> Pieces { get; set; }

        public string getFen(){
            throw new System.NotImplementedException();
        }

    }
}