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
    //For the Final Battle!!!
    class FinalBossBattle : Battle
    {
        //attributes
        private FinalBoss bierre;
        private BossEnemy tyler;
        private FinalBoss tank;

        //properties

        //constructor

        /// <summary>
        /// Final boss battle phase 1, just bierre.
        /// </summary>
        /// <param name="char1">Smartass Guy</param>
        /// <param name="char2">Low Jokes Guy</param>
        /// <param name="char3">Witty Guy</param>
        /// <param name="char4">Coffee Guy</param>
        /// <param name="prof">Input final boss here</param>
        public FinalBossBattle(SmartassGuy char1, LowJokesGuy char2, WittyGuy char3, CoffeeGuy char4, FinalBoss prof)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            bierre = prof;
        }

        /// <summary>
        /// Final Boss Battle Phase 2 tank appears
        /// </summary>
        /// <param name="char1">Smartass Guy</param>
        /// <param name="char2">Low Jokes Guy</param>
        /// <param name="char3">Witty Guy</param>
        /// <param name="char4">Coffee Guy</param>
        /// <param name="tank">tank boss goes here (Final Boss Object)</param>
        public FinalBossBattle(SmartassGuy char1, LowJokesGuy char2, WittyGuy char3, CoffeeGuy char4, FinalBoss tank)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            this.tank = tank;
        }

        /// <summary>
        /// final boss phase 3 the FINAL Battle
        /// </summary>
        /// <param name="char1">Smartass Guy</param>
        /// <param name="char2">Low Jokes Guy</param>
        /// <param name="char3">Witty Guy</param>
        /// <param name="char4">Coffee Guy</param>
        /// <param name="prof">bierre goes here</param>
        /// <param name="ta"> insert tyler here</param>
        public FinalBossBattle(SmartassGuy char1, LowJokesGuy char2, WittyGuy char3, CoffeeGuy char4, FinalBoss prof, BossEnemy ta)
        {
            c1 = char1;
            c2 = char2;
            c3 = char3;
            c4 = char4;
            bierre = prof;
            tyler = ta;
        }

        //methods

        /// <summary>
        /// Change the final boss phase if the previous one is defeated
        /// </summary>
        public void PhaseChange()
        {
            ///calls the second or third overload of Final Boss?
        }




    }
}
