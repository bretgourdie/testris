using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Testris.GameObject.Tetromino
{
    public class JPiece : Piece
    {
        public override Color Color => Color.Blue;

        protected override int[,] getInitialArrangement()
        {
            return new int[,]
                { { 1, 0, 0 },
                  { 1, 1, 1 },
                  { 0, 0, 0 } };
        }
    }
}
