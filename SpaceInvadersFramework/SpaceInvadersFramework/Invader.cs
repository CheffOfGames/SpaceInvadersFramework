using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Invader : SpriteGameObject
    {
        public Invader(String assetName) : base(assetName)
        {
            this.Velocity = new Vector2(100, 0);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Moving down when wall hit
            if (this.position.X > SpaceInvaders.Screen.X - this.sprite.Width || this.position.X < 0)
            {
                this.position.Y += 32;
                this.velocity *= -1;
            }
        }
    }
}