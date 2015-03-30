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
        Attack[] attacks; //Array of attacks to use on your opponent
        Item[] items; //Array of items to use on the character
        string name; //Character name
        string characterClass; //Character class
        int ego; //Ego (health) stat
        int humor; //Humor (attack) stat
        int intelligence; //Intelligence (defense) stat
        int energy; //Energy (speed) stat
        int wit; //Wit (buff) stat
        StreamReader fileReader;

        public Character() //Constructor
        {
            try //Try to read the file
            {
                // StreamReader fileReader = new StreamReader();
            }
            catch (IOException) //If the file cannot be read, default
            {
                name = "Default";
                characterClass = "Smartass Guy";
                ego = 103;
                humor = 5;
                intelligence = 15;
                energy = 10;
                wit = 10;
            }
        }

        // attributes
        public string Name
        {
            get { return name; }
        }

        public string Class
        {
            get { return characterClass; }
        }

        public int Ego
        {
            get { return ego; }
            set { ego = value; }
        }

        public int Humor
        {
            get { return humor; }
            set { humor = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        public int Wit
        {
            get { return wit; }
            set { wit = value; }
        }
    }
}
