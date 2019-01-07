using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Testris.GameObject.Tetromino;

namespace Testris
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Nez.Core
    {
        public Game1() : base(width: 800, height: 600, windowTitle: "Testris", enableEntitySystems: false)
        {
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            Window.AllowUserResizing = true;

            var myScene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);

            var tetromino = myScene.content.Load<Texture2D>("Textures/tetromino");

            var ipiece = myScene.createEntity("lpiece");
            ipiece.addComponent<IPiece>();
            ipiece.addComponent(new Sprite(tetromino));
            ipiece.position = new Vector2(100, 100);

            var jpiece = myScene.createEntity("jpiece");
            jpiece.addComponent<JPiece>();
            jpiece.addComponent(new Sprite(tetromino));
            jpiece.position = new Vector2(100, 150);

            var lpiece = myScene.createEntity("lpiece");
            lpiece.addComponent<LPiece>();
            lpiece.addComponent(new Sprite(tetromino));
            lpiece.position = new Vector2(100, 200);

            var opiece = myScene.createEntity("opiece");
            opiece.addComponent<OPiece>();
            opiece.addComponent(new Sprite(tetromino));
            opiece.position = new Vector2(100, 250);

            var spiece = myScene.createEntity("spiece");
            spiece.addComponent<SPiece>();
            spiece.addComponent(new Sprite(tetromino));
            spiece.position = new Vector2(100, 300);

            var tpiece = myScene.createEntity("tpiece");
            tpiece.addComponent<TPiece>();
            tpiece.addComponent(new Sprite(tetromino));
            tpiece.position = new Vector2(100, 350);

            Core.scene = myScene;
        }

    }
}
