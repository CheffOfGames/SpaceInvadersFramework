using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        GameObjectList invaders, bullets;
        Player thePlayer;

        public PlayingState()
        {
            thePlayer = new Player();
            thePlayer.Position = new Vector2(384, 580);

            this.invaders = new GameObjectList(0, "invaders");
            this.bullets = new GameObjectList(0, "bullets");

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i * 80 + 40, 0, "blue_invader"));
                this.invaders.Add(new Invader(i * 80 + 40, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i * 80 + 40, 128, "red_invader"));
            }
            this.Add(thePlayer);
            this.Add(invaders);
            this.Add(bullets);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                this.bullets.Add(new Bullet((int)thePlayer.Position.X, (int)thePlayer.Position.Y));
            }
        }
    }
}