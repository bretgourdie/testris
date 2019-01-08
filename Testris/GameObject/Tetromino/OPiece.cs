using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Testris.GameObject.Tetromino
{
    public class OPiece : Piece
    {
        public override Color Color => Color.Gold;

        protected override int[,] getInitialArrangement()
        {
            return new int[,]
                { { 0, 1, 1, 0 },
                  { 0, 1, 1, 0 },
                  { 0, 0, 0, 0 } };
        }
    }
}
