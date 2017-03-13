using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        public PlayingState()
        {
            Player thePlayer = new Player();
            thePlayer.Position = new Vector2(384, 580);

            Invader anInvader = new Invader("red_invader");
            anInvader.Position = new Vector2(0, 0);

            this.Add(thePlayer);
            this.Add(anInvader);
        }

        GameObjectList invaders = new GameObjectList(0,"invaders");
    }
}