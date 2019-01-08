using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Nez;
using Testris.GameLogic;

namespace Testris.GameObject.Tetromino
{
    public abstract class Piece : Component
    {
        public abstract Color Color { get; }

        public List<int[,]> ClockwiseArrangements { get; protected set; }

        public Piece() : base()
        {
            ClockwiseArrangements = createClockwiseArrangements();
            currentArrangementIndex = 0;
        }

        public int[,] GetCurrentArrangement()
        {
            return ClockwiseArrangements[currentArrangementIndex];
        }

        public void Rotate(RotationDirection direction)
        {
            int indexIncrementor;

            switch (direction)
            {
                case RotationDirection.Clockwise:
                    indexIncrementor = 1;
                    break;
                case RotationDirection.Counterclockwise:
                    indexIncrementor = -1;
                    break;
                default:
                    throw new NotImplementedException();
            }

            var desiredIndex = (currentArrangementIndex + 1 * indexIncrementor) % ClockwiseArrangements.Count;

            var desiredArrangement = ClockwiseArrangements[desiredIndex];

            if (canRotate(desiredArrangement))
            {
                currentArrangementIndex = desiredIndex;
            }
        }

        protected abstract List<int[,]> createClockwiseArrangements();

        private int currentArrangementIndex;

        private bool canRotate(int[,] desiredArrangement)
        {
            return true;
        }
    }
}
