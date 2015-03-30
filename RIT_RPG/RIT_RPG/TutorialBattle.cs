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
    //tutorial fight only needed once per new game
    class TutorialBattle : Battle
    {
        //attributes
        private BossEnemy tyler;

        //properties

        //constructor
        /// <summary>
        /// Creates the Tutorial battle at the beginning of the game
        /// </summary>
        /// <param name="char1">Smartass Guy</param>
        /// <param name="char2">Low Jokes Guy</param>
        /// <param name="char3">Witty Guy</param>
        /// <param name="char4">Coffee Guy</param>
        /// <param name="ta">Put Tyler here</param>
        public TutorialBattle(SmartassGuy char1, LowJokesGuy char2, WittyGuy char3, CoffeeGuy char4, BossEnemy ta)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            tyler = ta;
        }

        //methods

        public void EndTutorial()
        {
            //End "battle", 0 EXP allocated. 
        }

    }
}
