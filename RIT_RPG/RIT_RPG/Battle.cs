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
    //for simple Battles
    class Battle
    {
        //attributes
        protected PlayerChar c1;
        protected PlayerChar c2;
        protected PlayerChar c3;
        protected PlayerChar c4;
        private List<Enemy> enemies;
        private BattleMenu menu;

        //properties


        //Constructors

        /// <summary>
        /// Battle with 2 enemies
        /// </summary>
        /// <param name="char1">CoffeeGuy</param>
        /// <param name="char2">WittyGuy</param>
        /// <param name="char3">SmartGuy</param>
        /// <param name="char4">FunnyGuy</param>
        /// <param name="enem1"></param>
        /// <param name="enem2"></param>
        /// <param name="enem3"></param>
        public Battle(BattleMenu bM, CoffeeGuy char1, WittyGuy char2, SmartGuy char3, FunnyGuy char4, Enemy enem1, Enemy enem2)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            enemies.Add(enem1);
            enemies.Add(enem2);
            menu = bM;
        }

        /// <summary>
        /// Battle with 3 enemies
        /// </summary>
        /// <param name="char1">CoffeeGuy</param>
        /// <param name="char2">WittyGuy</param>
        /// <param name="char3">SmartGuy</param>
        /// <param name="char4">FunnyGuy</param>
        /// <param name="enem1"></param>
        /// <param name="enem2"></param>
        /// <param name="enem3"></param>
        public Battle(BattleMenu bM, CoffeeGuy char1, WittyGuy char2, SmartGuy char3, FunnyGuy char4, Enemy enem1, Enemy enem2, Enemy enem3)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            enemies.Add(enem1);
            enemies.Add(enem2);
            enemies.Add(enem3);
            menu = bM;
        }

        /// <summary>
        /// Battle with 4 enemies
        /// </summary>
        /// <param name="char1">CoffeeGuy</param>
        /// <param name="char2">WittyGuy</param>
        /// <param name="char3">SmartGuy</param>
        /// <param name="char4">FunnyGuy</param>
        /// <param name="enem1"></param>
        /// <param name="enem2"></param>
        /// <param name="enem3"></param>
        public Battle(BattleMenu bM, CoffeeGuy char1, WittyGuy char2, SmartGuy char3, FunnyGuy char4, Enemy enem1, Enemy enem2, Enemy enem3, Enemy enem4)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            enemies.Add(enem1);
            enemies.Add(enem2);
            enemies.Add(enem3);
            enemies.Add(enem4);
            menu = bM;
        }

        //Methods
        //commented out
        //public int TakeDamage()
        //{
            //subtract / add health,
            
            //check if players or enemies are dead
            
            //check if Battle is over or Game Over
            //if(c1.Ego == 0 && c2.Ego == 0 && c3.Ego == 0 && c4.Ego == 0)
            //{
                  //this.GameOver();
            //}
            
            //int deadEnemyCount = 0 // set up a count of enemies that have died
            //foreach(Enemy e in enemies)
            //{
            //    if(e.Health == 0)
            //    {
            //        deadEnemyCount++;
            //    }
            //}
            //
            //if(deadEnemyCount == enemies.Length)
            //{
            //    this.EndBattle();
            //}
        //}
        //commented out

        /// <summary>
        ///  this method will handle all of the meat of the battle
        /// </summary>
        public void RunBattle()
        {
            // loop to see if either enemy party or player party is dead

            // inside loop determine who goes first based on speed

            // if player characters go first then call methods depending on selection inside the battle menu
            menu.ProcessInput();

            // if enemys go first then they randomly target a player character and call appropriate method

            // if bettle ends then call endBattle or gameOver method
        }

        /// <summary>
        /// Brings up the battle Menu and the battlescreen
        /// </summary>
        public void DrawScreen()
        {
            //Draw Background 

            //Draw menu
            menu.DrawMenu();
            
            //Draw Enemies and player characters
        }

        /// <summary>
        /// Ends the battle if the player wins
        /// </summary>
        public void EndBattle()
        {
            //allocate EXP
            //level up?
            //Draw Overworld
        }

        /// <summary>
        /// if all allies are dead, Draw Game Over Screen
        /// </summary>
        public void GameOver()
        {
            //draw Game Over screen
        }



        

    }
}
