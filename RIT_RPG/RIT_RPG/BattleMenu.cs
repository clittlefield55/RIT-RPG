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
    class BattleMenu:SmallMenu
    {
        int selectorHeight = 40;
        int selectorWidth;
        Texture2D selectorTex; // texture for the selector
        Rectangle selector; // the selector, which will update in the draw menu constantly
        Vector2 selectorPos; // the current position of the selector
        Vector2 attackPos; // position of attack label
        Vector2 itemPos; // position of item label
        Vector2 summonPos; // position of the summon ritchie label
        Vector2 runPos; // position of the run away label
        public BattleMenu(GraphicsDeviceManager gr, SpriteBatch sp, Texture2D bak, Texture2D sel, Vector2 pos, int ht, int wd):base(gr, sp, bak, pos, ht, wd)
        {
            selectorTex = sel;
            selectorWidth = (width / 2) - 30;

            // use complicated algorithms to set the positions of the label vectors
            attackPos = new Vector2(position.X + 20, position.Y + 60);
            itemPos = new Vector2((width - selectorWidth - 10), position.Y + 60);
            summonPos = new Vector2(position.X + 20, (position.Y + height) - (selectorHeight + 10));
            runPos = new Vector2((width - selectorWidth - 10), (position.Y + height) - (selectorHeight + 10));

            selectorPos = attackPos; // by default, the selector is over the attack label first
        }

        public override void DrawMenu()
        {
            base.DrawMenu();

            // define the action selector, with offsets from the label vectors
            selector = new Rectangle((int)selectorPos.X - 5, (int)selectorPos.Y - 5, selectorWidth, selectorHeight);
            sprite.Draw(selectorTex, selector, Color.White);
        }

        public void ProcessInput()
        {
            kState = Keyboard.GetState();

            // these logic statements move the selector to the desired label based on the labels around it
            if((selectorPos == summonPos && kState.IsKeyDown(Keys.W) == true) || (selectorPos == itemPos && kState.IsKeyDown(Keys.A) == true))
            {
                selectorPos = attackPos;
            }

            else if ((selectorPos == attackPos && kState.IsKeyDown(Keys.D) == true) || (selectorPos == runPos && kState.IsKeyDown(Keys.W) == true))
            {
                selectorPos = itemPos;
            }

            else if ((selectorPos == attackPos && kState.IsKeyDown(Keys.S) == true) || (selectorPos == runPos && kState.IsKeyDown(Keys.A) == true))
            {
                selectorPos = summonPos;
            }

            else if ((selectorPos == summonPos && kState.IsKeyDown(Keys.D) == true) || (selectorPos == itemPos && kState.IsKeyDown(Keys.S) == true))
            {
                selectorPos = runPos;
            }
        }
    }
}
