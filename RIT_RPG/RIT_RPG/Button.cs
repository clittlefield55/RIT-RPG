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
    class Button
    {
        GraphicsDeviceManager graph;
        SpriteBatch sprite;
        int width;
        int height;
        Texture2D butTex;
        Vector2 position;
        Rectangle buttonBox;

        public Button(GraphicsDeviceManager gr, SpriteBatch sp, Vector2 pos, Texture2D tex, int wd, int ht)
        {
            graph = gr;
            sprite = sp;
            width = wd;
            height = ht;
            position = pos;
            butTex = tex;
            buttonBox = new Rectangle((int)position.X, (int)position.Y, width, height);
        }

        public Vector2 Position
        {
            get { return position; }
        }
        public Texture2D ButTex
        {
            get { return butTex; }
        }
        public Rectangle ButtonBox
        {
            get { return buttonBox; }
        }
        public int Width
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }

        public void DrawButton()
        {
            sprite.Draw(butTex, buttonBox, Color.White);
        }
    }
}
