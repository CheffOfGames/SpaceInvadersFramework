﻿using Microsoft.Xna.Framework;
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
            if (inputHelper.IsKeyDown(Keys.Left) && this.position.X >= 0)
            {
                this.velocity = new Vector2(-300, 0);
            }
            else
            {
                this.velocity = Vector2.Zero;
            }

            if (inputHelper.IsKeyDown(Keys.Right) && this.position.X <= SpaceInvaders.Screen.X - this.sprite.Width)
            {
                this.velocity = new Vector2(300, 0);
            }
        }
    }
}