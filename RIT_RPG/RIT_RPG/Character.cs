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
    abstract class Character
    {
        string name; //Character name
        string characterClass; //Character class
        int ego; //Ego (health) stat
        int humor; //Humor (attack) stat
        int inteligence; //Inteligence (defense) stat
        int energy; //Energy (speed) stat
        int wit; //Wit (buff) stat

        public Character() //Constructor
        {
            try //Try to read the file
            {
                //StreamReader fileReader = new StreamReader();
            }
            catch (IOException) //If the file cannot be read, default
            {
                name = "Default";
                characterClass = "Smartass Guy";
                ego = 103;
                humor = 5;
                inteligence = 15;
                energy = 10;
                wit = 10;
            }
        }


    }
}
