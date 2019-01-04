using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace Testris.Components
{
    public class SimpleMover : Component, IUpdatable
    {
        public float speed = 100f;
        public void update()
        {
            var moveDirection = Vector2.Zero;

            if (Input.isKeyDown(Keys.Left))
            {
                moveDirection.X = -1f;
            }
            else if (Input.isKeyDown(Keys.Right))
            {
                moveDirection.X = 1f;
            }

            if (Input.isKeyDown(Keys.Up))
            {
                moveDirection.Y = -1f;
            }

            else if (Input.isKeyDown(Keys.Down))
            {
                moveDirection.Y = 1f;
            }

            this.entity.position += moveDirection * speed * Time.deltaTime;
        }
    }
}
