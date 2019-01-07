using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
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

            var ipiece = this.createEntity("lpiece");
            ipiece.addComponent<IPiece>();
            ipiece.addComponent(new Sprite(tetromino));
            ipiece.position = new Vector2(100, 100);

            var jpiece = this.createEntity("jpiece");
            jpiece.addComponent<JPiece>();
            jpiece.addComponent(new Sprite(tetromino));
            jpiece.position = new Vector2(100, 150);

            var lpiece = this.createEntity("lpiece");
            lpiece.addComponent<LPiece>();
            lpiece.addComponent(new Sprite(tetromino));
            lpiece.position = new Vector2(100, 200);

            var opiece = this.createEntity("opiece");
            opiece.addComponent<OPiece>();
            opiece.addComponent(new Sprite(tetromino));
            opiece.position = new Vector2(100, 250);

            var spiece = this.createEntity("spiece");
            spiece.addComponent<SPiece>();
            spiece.addComponent(new Sprite(tetromino));
            spiece.position = new Vector2(100, 300);

            var tpiece = this.createEntity("tpiece");
            tpiece.addComponent<TPiece>();
            tpiece.addComponent(new Sprite(tetromino));
            tpiece.position = new Vector2(100, 350);
        }
    }
}
