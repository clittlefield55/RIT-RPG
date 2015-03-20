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
    abstract class Menu
    {
        protected KeyboardState kState;
        protected GraphicsDeviceManager graph;
        protected SpriteBatch sprite;
        protected Texture2D background; // background image
        protected Vector2 position; // upper left position of menu
        protected int height; // height of menu
        protected int width; // width of menu
        protected int center; // center of menu

        // constructor
        public Menu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Vector2 pos, int ht, int wd)
        {
            graph = gr;
            sprite = sp;
            background = bak;
            position = pos;
            height = ht;
            width = wd;
            center = width / 2; // set the xCenter to half the current window value
        }

        // draw method
        public virtual void DrawMenu()
        {
            sprite.Draw(background, new Rectangle((int)position.X, (int)position.Y, width, height), Color.White);
        }
    }
}
