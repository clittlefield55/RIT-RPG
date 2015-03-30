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
        int menuPages; // pages of the attack and items menu, 4 options per page
        Texture2D selectorTex; // texture for the selector
        Rectangle selector; // the selector, which will update in the draw menu constantly
        Vector2 selectorPos; // the current position of the selector
        Vector2 pos1; // position of attack label
        Vector2 pos2; // position of item label
        Vector2 pos3; // position of the summon ritchie label
        Vector2 pos4; // position of the run away label
        SpriteFont battleFont; // font for menu

        // the Battle state will decide how the menu will be controlled and drawn
        enum BattleState { Main, Attack, Items, Summon, Run}
        BattleState currentState = new BattleState();
        public BattleMenu(GraphicsDeviceManager gr, SpriteBatch sp, SpriteFont sf, Texture2D bak, Texture2D sel, Vector2 pos, int ht, int wd):base(gr, sp, bak, pos, ht, wd)
        {
            selectorTex = sel;
            selectorWidth = (width / 2) - 30; // the width of the selector changes depending on the size of the game window
            battleFont = sf;

            // use complicated algorithms to set the positions of the label vectors
            pos1 = new Vector2(position.X + 20, position.Y + 60);
            pos2 = new Vector2((width - selectorWidth - 10), position.Y + 60);
            pos3 = new Vector2(position.X + 20, (position.Y + height) - (selectorHeight + 10));
            pos4 = new Vector2((width - selectorWidth - 10), (position.Y + height) - (selectorHeight + 10));

            currentState = BattleState.Main; // by default, the menu state is in the action selection menu first
            selectorPos = pos1; // by default, the selector is over the attack label first
        }

        public override void DrawMenu()
        {
            base.DrawMenu();

            switch(currentState)
            {
                case BattleState.Main:
                    // define the action selector, with offsets from the label vectors
                    selector = new Rectangle((int)selectorPos.X - 5, (int)selectorPos.Y - 5, selectorWidth, selectorHeight);
                    sprite.Draw(selectorTex, selector, Color.White);
                    // draw the attack label
                    sprite.DrawString(battleFont, "Attack", pos1, Color.White);

                    // draw the item label
                    sprite.DrawString(battleFont, "Items", pos2, Color.White);

                    // draw the summon label
                    sprite.DrawString(battleFont, "Summon RITchie!", pos3, Color.White);

                    // draw the run label
                    sprite.DrawString(battleFont, "Run Away", pos4, Color.White);
                    break;
                case BattleState.Attack:
                    // add the attack selection menu code here
                    break;
                case BattleState.Items:
                    // add the item selection menu code here
                    break;
                case BattleState.Summon:
                    // add the summon RITchie code here
                    break;
                case BattleState.Run:
                    // add running away code here.
                    break;
            }
        }

        // called in the update class
        public void ProcessInput()
        {
            kState = Keyboard.GetState();

                // these logic statements move the selector to the desired label based on the labels around it
            if ((selectorPos == pos3 && kState.IsKeyDown(Keys.W) == true) || (selectorPos == pos2 && kState.IsKeyDown(Keys.A) == true))
                {
                    selectorPos = pos1;
                }

            else if ((selectorPos == pos1 && kState.IsKeyDown(Keys.D) == true) || (selectorPos == pos4 && kState.IsKeyDown(Keys.W) == true))
                {
                    selectorPos = pos2;
                }

            else if ((selectorPos == pos1 && kState.IsKeyDown(Keys.S) == true) || (selectorPos == pos4 && kState.IsKeyDown(Keys.A) == true))
                {
                    selectorPos = pos3;
                }

            else if ((selectorPos == pos3 && kState.IsKeyDown(Keys.D) == true) || (selectorPos == pos2 && kState.IsKeyDown(Keys.S) == true))
                {
                    selectorPos = pos4;
                }

                switch (currentState)
                {
                #region Main
                case BattleState.Main:
                    // selecting the attack action
                        if (selectorPos == pos1 && kState.IsKeyDown(Keys.E) == true)
                    {
                        this.DisplayAttack();
                        currentState = BattleState.Attack;
                    }

                    // selecting the items action
                        if (selectorPos == pos2 && kState.IsKeyDown(Keys.E) == true)
                    {
                        this.DisplayAttack();
                        currentState = BattleState.Items;
                    }

                    break;
                #endregion
                case BattleState.Attack:
                    // add the attack selection menu code here
                    if (kState.IsKeyDown(Keys.Q) == true) // if the Q key is pressed at any time
                    {
                        currentState = BattleState.Main; // return to the main menu
                    }
                    break;
                case BattleState.Items:
                    // add the item selection menu code here
                    if (kState.IsKeyDown(Keys.Q) == true) // if the Q key is pressed at any time
                    {
                        currentState = BattleState.Main; // return to the main menu
                    }
                    break;
                case BattleState.Summon:
                    // add the summon RITchie code here
                    break;
                case BattleState.Run:
                    // add running away code here.
                    break;
            }
        }

        public void DisplayAttack()
        {
            
        }

        public void DisplayItems()
        {

        }
    }
}
