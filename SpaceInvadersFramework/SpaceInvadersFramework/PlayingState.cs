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
        Score score;

        public PlayingState()
        {
            thePlayer = new Player();
            thePlayer.Position = new Vector2(384, 580);

            this.invaders = new GameObjectList(0, "invaders");
            this.bullets = new GameObjectList(0, "bullets");
            this.score = new Score();

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i * 80 + 40, 0, "blue_invader"));
                this.invaders.Add(new Invader(i * 80 + 40, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i * 80 + 40, 128, "red_invader"));
            }
            this.Add(new SpriteGameObject("background"));
            this.Add(score);
            this.Add(invaders);
            this.Add(bullets);
            this.Add(thePlayer);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                this.bullets.Add(new Bullet(thePlayer.Position));
            }


            foreach (Invader Invader in invaders.Objects)
            {
                foreach (Bullet Bullet in bullets.Objects)
                {
                    if (Invader.CollidesWith(Bullet))
                    {
                        Invader.Visible = false;
                        Bullet.Visible = false;
                        Score.ScoreValue += 10;
                    }
                }
            }
        }

        public GameObjectList Bullets
        {
            get
            {
                return bullets;
            }
            set
            {
                bullets = value;
            }
        }
        internal Score Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
    }
}