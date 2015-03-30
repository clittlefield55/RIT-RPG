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
using System.IO; //Using file input and output

namespace RIT_RPG
{
    class LowJokesGuy:Character //Handles files for the Low Jokes Guy
    {
        public LowJokesGuy(string fileName):base(fileName) //Constructor
        {

        }

        public override void ExpGain(int expGained) //Handles exp gain
        {
            #region Handles exp gain, calls the LevelUp method if needed
            exp += expGained; //Calculate the new experience

            if (exp >= 100) //If the player has more than 100 experience points
            {
                LevelUp(); //Call the LevelUp method
            }
            #endregion

            #region Write the new exp to the character file
            else //If the player did not level up
            {
                StreamWriter fileWriter = new StreamWriter("lowjokesGuy.bin"); //Create the StreamWriter object
                fileWriter.Write(name + ","); //Write the character's name
                fileWriter.Write(characterClass + ","); //Write the character's class
                fileWriter.Write(level + ","); //Add the character's level
                fileWriter.Write(exp + ","); //Add the character's experience points
                fileWriter.Close(); //Close the StreamWriter
            }
            #endregion
        }

        public override void LevelUp() //Handles character levelup
        {
            #region Handles stat distribution and recalculates exp
            exp -= 100; //Calculate the new experience
            level += 1; //Give the character a new level
            ego += ((ego % 5) + 2); //Calculates the new ego stat
            humor += ((humor % 4) + 1); //Calculates the new humor stat
            inteligence += ((inteligence % 4) + 1); //Calculates the new inteligence stat
            energy += ((energy % 3) + 1); //Calculates the new energy stat
            wit += ((wit % 5) + 1); //Calculates the new wit stat
            #endregion

            #region Writes the stat changes to the character file
            StreamWriter fileWriter = new StreamWriter("lowjokesGuy.bin"); //Create the StreamWriter object
            fileWriter.Write(name + ","); //Write the character's name
            fileWriter.Write(characterClass + ","); //Write the character's class
            fileWriter.Write(level + ","); //Add the character's level
            fileWriter.Write(exp + ","); //Add the character's experience points
            fileWriter.Write(ego + ","); //Add the character's ego stat
            fileWriter.Write(humor + ","); //Add the character's humor stat
            fileWriter.Write(inteligence + ","); //Add the character's inteligence stat
            fileWriter.Write(energy + ","); //Add the character's energy stat
            fileWriter.Write(wit); //Add the character's wit stat
            fileWriter.Close(); //Close the StreamWriter
            #endregion
        }

        public override void Insult() //Character attack method
        {
            throw new NotImplementedException();
        }
    }
}
