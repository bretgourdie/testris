using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Nez;

namespace Testris.GameObject.Tetromino
{
    public abstract class Piece : Component
    {
        public abstract Color Color { get; }
    }
}
