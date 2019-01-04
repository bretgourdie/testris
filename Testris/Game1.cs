using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

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
            var texture = myScene.content.Load<Texture2D>("Textures/sample");

            var entityOne = myScene.createEntity("entity-one");
            entityOne.addComponent(new Sprite(texture));
            var entityTwo = myScene.createEntity("entity-two");
            entityTwo.addComponent(new Sprite(texture));
            entityTwo.position = new Vector2(200, 200);

            Core.scene = myScene;
        }

    }
}
