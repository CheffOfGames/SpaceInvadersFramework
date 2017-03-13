using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Bullet : SpriteGameObject
    {
        public Bullet(Vector2 startPos) : base("bullet")
        {
            this.velocity = new Vector2(0, -400);
            this.position = startPos;
        }
    }
}
