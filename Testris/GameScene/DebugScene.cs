using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Testris.GameObject.Tetromino;

namespace Testris.GameScene
{
    public class DebugScene : Nez.Scene
    {
        public override void initialize()
        {
            base.initialize();

            this.addRenderer(new DefaultRenderer());

            var tetromino = this.content.Load<Texture2D>("Textures/tetromino");
            Piece.Texture = tetromino;

            var ipiece = this.createEntity("lpiece");
            ipiece.addComponent<IPiece>();
            ipiece.position = new Vector2(100, 100);

            var jpiece = this.createEntity("jpiece");
            jpiece.addComponent<JPiece>();
            jpiece.position = new Vector2(100, 150);

            var lpiece = this.createEntity("lpiece");
            lpiece.addComponent<LPiece>();
            lpiece.position = new Vector2(100, 200);

            var opiece = this.createEntity("opiece");
            opiece.addComponent<OPiece>();
            opiece.position = new Vector2(100, 250);

            var spiece = this.createEntity("spiece");
            spiece.addComponent<SPiece>();
            spiece.position = new Vector2(100, 300);

            var tpiece = this.createEntity("tpiece");
            tpiece.addComponent<TPiece>();
            tpiece.position = new Vector2(100, 350);
        }
    }
}
