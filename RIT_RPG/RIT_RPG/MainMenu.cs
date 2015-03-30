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
    class MainMenu:Menu
    {
        protected int logoWidth; // width of the logo rectangle
        protected int logoHeight; // height of the logo rectangle
        protected Rectangle newButton; // new button drawn to the screen
        protected Rectangle loadButton; // load button drawn to the screen
        protected Rectangle logo; // The size and position of the logo;
        protected Texture2D ritLogo; // the texture of the game logo
        protected Button button1;
        protected Button button2;
        protected Button button3;

        // no button overload
        public MainMenu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Texture2D gLogo, Vector2 pos, int ht, int wd)
            : base(gr, sp, bak, pos, ht, wd)
        {
            ritLogo = gLogo;
            center = (width / 2);
            logoWidth = ritLogo.Width / 2;
            logoHeight = ritLogo.Height / 2;
            logo = new Rectangle(center - (logoWidth / 2), 40, logoWidth, logoHeight);
        }

        // one button overload
        public MainMenu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Texture2D gLogo, Vector2 pos, int ht, int wd, Button b1)
            : base(gr, sp, bak, pos, ht, wd)
        {
            ritLogo = gLogo;
            center = (width / 2);
            logoWidth = ritLogo.Width / 2;
            logoHeight = ritLogo.Height / 2;
            logo = new Rectangle(center - (logoWidth / 2), 40, logoWidth, logoHeight);
            button1 = b1;
        }

        // two button overload
        public MainMenu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Texture2D gLogo, Vector2 pos, int ht, int wd, Button b1, Button b2)
            : base(gr, sp, bak, pos, ht, wd)
        {
            ritLogo = gLogo;
            center = (width / 2);
            logoWidth = ritLogo.Width / 2;
            logoHeight = ritLogo.Height / 2;
            logo = new Rectangle(center - (logoWidth / 2), 40, logoWidth, logoHeight);
            button1 = b1;
            button2 = b2;
        }

        // three button overload
        public MainMenu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Texture2D gLogo, Vector2 pos, int ht, int wd, Button b1, Button b2, Button b3)
            : base(gr, sp, bak, pos, ht, wd)
        {
            ritLogo = gLogo;
            center = (width / 2);
            logoWidth = ritLogo.Width / 2;
            logoHeight = ritLogo.Height / 2;
            logo = new Rectangle(center - (logoWidth / 2), 40, logoWidth, logoHeight);
            button1 = b1;
            button2 = b2;
            button3 = b3;
        }

        public override void DrawMenu()
        {
            base.DrawMenu();
            sprite.Draw(ritLogo, logo, Color.White);

            // some of the overloaded methods have buttons assigned to them, 
            // these if statements only draw the buttons if something is actually assigned to them.
            if(button1 != null)
            {
                button1.DrawButton();
            }
            if (button2 != null)
            {
                button2.DrawButton();
            }
            if (button3 != null)
            {
                button3.DrawButton();
            }
        }
    }
}
