using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;
using Testris.GameLogic;
using System.Diagnostics.CodeAnalysis;

namespace Testris.GameObject.Tetromino
{
    public abstract class Piece : Component
    {
        public abstract Color Color { get; }

        public List<int[,]> ClockwiseArrangements { get; protected set; }

        private Sprite _sprite { get; set; }

        public Piece() : base()
        {
            ClockwiseArrangements = createClockwiseArrangements();
            currentArrangementIndex = 0;
        }

        [SuppressMessage("Warning", "CS0114")]
        public virtual void onAddedToEntity()
        {
            _sprite = entity.getComponent<Sprite>();
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
                    throw new ArgumentException();
            }

            var uncorrectedDesiredIndex = currentArrangementIndex + 1 * indexIncrementor;

            var desiredIndex = uncorrectedDesiredIndex % ClockwiseArrangements.Count;

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
