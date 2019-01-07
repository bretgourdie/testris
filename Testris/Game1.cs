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

            var ipiece = myScene.createEntity("lpiece");
            ipiece.addComponent<IPiece>();

            var jpiece = myScene.createEntity("jpiece");
            jpiece.addComponent<JPiece>();

            var lpiece = myScene.createEntity("lpiece");
            lpiece.addComponent<LPiece>();

            var opiece = myScene.createEntity("opiece");
            opiece.addComponent<OPiece>();

            var spiece = myScene.createEntity("spiece");
            spiece.addComponent<SPiece>();

            var tpiece = myScene.createEntity("tpiece");
            tpiece.addComponent<TPiece>();

            Core.scene = myScene;
        }

    }
}
