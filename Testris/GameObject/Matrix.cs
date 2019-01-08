using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testris.GameObject.Tetromino;

namespace Testris.GameObject
{
    public class Matrix
    {
        public int[,] Grid = new int[40, 10];

        private const int startingX = 4;
        private const int startingY = 21;
    }
}
