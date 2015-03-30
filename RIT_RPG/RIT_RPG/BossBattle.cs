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
    //Boss Battles, EX: Destler or other bosses we want
    class BossBattle : Battle
    {
        //attributes - unique to Boss Fight
        private BossEnemy boss;

        //properties

        //Constructor

        /// <summary>
        /// Creates the Boss battle, usual 4 player characters and 1 boss
        /// </summary>
        /// <param name="char1">Smartass Guy</param>
        /// <param name="char2">Low Jokes Guy</param>
        /// <param name="char3">Witty Guy</param>
        /// <param name="char4">Coffee Guy</param>
        /// <param name="bossChar"> accepts the bosses into the parameter</param>
        public BossBattle(SmartassGuy char1, LowJokesGuy char2, WittyGuy char3, CoffeeGuy char4, BossEnemy bossChar)
        {
            //set the variables to their respective variables (final names subject to change)
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            boss = bossChar;
        }


    }
}
