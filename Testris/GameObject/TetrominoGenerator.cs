using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testris.GameObject.Tetromino;

namespace Testris.GameObject
{
    public class TetrominoGenerator
    {

        private List<Type> baseBag { get; set; }

        private Random random = new Random();

        public Queue<Type> PieceQueue { get; private set; }

        private const int minPieceQueueLength = 10;

        public TetrominoGenerator()
        {
            baseBag = new List<Type>()
            {
                typeof(IPiece),
                typeof(JPiece),
                typeof(LPiece),
                typeof(OPiece),
                typeof(SPiece),
                typeof(TPiece),
                typeof(ZPiece)
            };

            PieceQueue = new Queue<Type>();
            feedQueue();
        }

        private bool queueNeedsFed()
        {
            return PieceQueue.Count < minPieceQueueLength;
        }

        private void feedQueue()
        {
            var shuffledList = shuffleBaseBag();

            shuffledList.ForEach(x => PieceQueue.Enqueue(x));
        }

        private List<Type> shuffleBaseBag()
        {
            var shuffledList = new List<Type>(baseBag);

            for (var i = 0; i < shuffledList.Count; i++)
            {
                var randomIndex = random.Next(i, shuffledList.Count);
                var temp = shuffledList[i];
                shuffledList[i] = shuffledList[randomIndex];
                shuffledList[randomIndex] = temp;
            }

            return shuffledList;
        }
    }
}
