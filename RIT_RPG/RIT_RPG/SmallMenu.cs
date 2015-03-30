using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace RIT_RPG
{
    // this class is abstract, it is not meant to be created as an object (Create BattleMenu and SpeechMenu objects instead)
    abstract class SmallMenu:Menu
    {
        public SmallMenu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Vector2 pos, int ht, int wd):base(gr, sp, bak, pos, ht, wd)
        {
        }

        public override void DrawMenu()
        {
            base.DrawMenu();
        }
    }
}
