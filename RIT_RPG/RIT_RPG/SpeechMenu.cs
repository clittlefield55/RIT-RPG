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

    class SpeechMenu:SmallMenu
    {
        SpriteFont font;
        string text;
        public SpeechMenu(GraphicsDeviceManager gr, SpriteBatch sp, SpriteFont ft, Texture2D bak, Vector2 pos, int ht, int wd):base(gr,sp,bak,pos,ht,wd)
        {
            font = ft;
        }

        // When character classes have been added, uncomment this method
        /*public void Talk(Character ch, string tx)
        {
            text = ch.Name + ": " + tx
            base.DrawMenu();
            sprite.DrawString(font, text, new Vector2((int)position.X + 20, (int)position.Y + 20), Color.White);
        }*/
    }
}
