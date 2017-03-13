using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        GameObjectList invaders;
        
        public PlayingState()
        {
            Player thePlayer = new Player();
            thePlayer.Position = new Vector2(384, 580);

            this.invaders = new GameObjectList(0, "invaders");

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i * 80 + 40, 0, "blue_invader"));
                this.invaders.Add(new Invader(i * 80 + 40, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i * 80 + 40, 128, "red_invader"));
            }

            this.Add(thePlayer);
            this.Add(invaders);
        }
    }
}