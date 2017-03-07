using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        public Player() : base("ship") { }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Left))
            {
                this.position.X--;
            }

            if (inputHelper.KeyPressed(Keys.Right))
            {
                this.position.X++;
            }
        }
    }
}
