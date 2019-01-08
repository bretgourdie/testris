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

        protected override List<int[,]> createClockwiseArrangements()
        {
            return new List<int[,]>()
            {
                new int[,]
                {
                    { 1, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 }
                },
                new int[,]
                {
                    { 0, 1, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 }
                },
                new int[,]
                {
                    { 0, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 1 }
                },
                new int[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 1, 0 }
                }
            };
        }
    }
}
