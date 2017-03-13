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

            this.Add(thePlayer);
        }
    }
}
