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
    abstract class Character //Handles reading of character files
    {
        #region Attributes
        protected string name; //Character name
        protected string characterClass; //Character class
        protected int level; //Character level
        protected int exp; //Character experience points
        protected int ego; //Ego (health) stat
        protected int humor; //Humor (attack) stat
        protected int inteligence; //Inteligence (defense) stat
        protected int energy; //Energy (speed) stat
        protected int wit; //Wit (buff) stat
        protected int egoInBattle; //Ego stat when the player is in battle
        protected int damage; //Damage the character takes in battle
        #endregion

        public Character(string fileName) //Constructor
        {
            #region Try to read in the character file
            try //Try to read the file
            {
                StreamReader fileReader = new StreamReader(fileName); //Creates a streamreader to read the file
                string line = null; //Stores the strings to be read from the file
                string[] characterData = new string[9]; //An array to hold the nine pieces of data from the file
                while ((line = fileReader.ReadLine()) != null) //While there is data to be read
                {
                    characterData = line.Split(','); //Tells the array where each piece of data ends
                    name = characterData[0]; //Give the character the name specified in the file
                    characterClass = characterData[1]; //Give the character the class specified in the file
                    level = int.Parse(characterData[2]); //Give the character the level specified in the file
                    exp = int.Parse(characterData[3]); //Give the character the amount of experience specified in the file
                    ego = int.Parse(characterData[4]); //Give the character the ego stat specified in the file
                    humor = int.Parse(characterData[5]); //Give the character the humor stat specified in the file
                    inteligence = int.Parse(characterData[6]); //Give the character the inteligence stat specified in the file
                    energy = int.Parse(characterData[7]); //Give the character the energy stat specified in the file
                    wit = int.Parse(characterData[8]); //Give the character the wit stat specified in the file
                }
                fileReader.Close(); //Closes the fileReader
            }
            #endregion

            #region If an exception is thrown, create a new character file
            catch (Exception) //If the file cannot be read, default
            {
                StreamWriter fileWriter = null; //Create the StreamWriter object

                if (fileName == "smartassGuy.bin") //If the file was for the Smartass Guy
                {
                    name = "Smartass Guy"; //Gives the character a default name
                    characterClass = "Smartass Guy"; //Sets the character to the default class
                    level = 1; //Sets the character to the default level
                    exp = 0; //Gives the character the default amount of experience
                    ego = 103; //Gives the character the default ego stat
                    humor = 5; //Gives the character the default humor stat
                    inteligence = 15; //Gives the character the default inteligence stat
                    energy = 10; //Gives the character the default energy stat
                    wit = 10; //Gives the character the default wit stat

                    fileWriter = new StreamWriter(fileName); //Filename, to create the character files
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
                }
                if (fileName == "lowjokesGuy.bin") //If the file was for the low jokes Guy
                {
                    name = "Low Jokes Guy"; //Gives the character a default name
                    characterClass = "Low Jokes Guy"; //Sets the character to the default class
                    level = 1; //Sets the character to the default level
                    exp = 0; //Gives the character the default amount of experience
                    ego = 100; //Gives the character the default ego stat
                    humor = 15; //Gives the character the default humor stat
                    inteligence = 5; //Gives the character the default inteligence stat
                    energy = 13; //Gives the character the default energy stat
                    wit = 10; //Gives the character the default wit stat

                    fileWriter = new StreamWriter(fileName); //Filename, to create the character files
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
                }
                if (fileName == "wittyGuy.bin") //If the file was for the Witty Guy
                {
                    name = "Witty Guy"; //Gives the character a default name
                    characterClass = "Witty Guy"; //Sets the character to the default class
                    level = 1; //Sets the character to the default level
                    exp = 0; //Gives the character the default amount of experience
                    ego = 100; //Gives the character the default ego stat
                    humor = 13; //Gives the character the default humor stat
                    inteligence = 10; //Gives the character the default inteligence stat
                    energy = 5; //Gives the character the default energy stat
                    wit = 15; //Gives the character the default wit stat

                    fileWriter = new StreamWriter(fileName); //Filename, to create the character files
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
                }
                if (fileName == "coffeeGuy.bin") //If the file was for the Coffee Guy
                {
                    name = "Coffee Guy"; //Gives the character a default name
                    characterClass = "Coffee Guy"; //Sets the character to the default class
                    level = 1; //Sets the character to the default level
                    exp = 0; //Gives the character the default amount of experience
                    ego = 105; //Gives the character the default ego stat
                    humor = 5; //Gives the character the default humor stat
                    inteligence = 10; //Gives the character the default inteligence stat
                    energy = 13; //Gives the character the default energy stat
                    wit = 10; //Gives the character the default wit stat

                    fileWriter = new StreamWriter(fileName); //Filename, to create the character files
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
                }
            }
            #endregion
        }

        #region Properties
        public string Name //Name property
        {
            get { return name; }
        }
        public string CharacterClass //CharacterClass property
        {
            get { return characterClass; }
        }
        public int Level //Level property
        {
            get { return level; }
            set { level = value; }
        }
        public int Exp //Exp property
        {
            get { return exp; }
            set { exp = value; }
        }
        public int Ego //Ego property
        {
            get { return ego; }
            set { ego = value; }
        }
        public int Humor //Humor property
        {
            get { return humor; }
            set { humor = value; }
        }
        public int Inteligence //Inteligence property
        {
            get { return inteligence; }
            set { inteligence = value; }
        }
        public int Energy //Energy property
        {
            get { return energy; }
            set { energy = value; }
        }
        public int Wit //Wit property
        {
            get { return wit; }
            set { wit = value; }
        }
        public int EgoInBattle //EgoInBattle property
        {
            get { return egoInBattle; }
            set { egoInBattle = value; }
        }
        public int Damage //Damage property
        {
            get { return damage; }
            set { damage = value; }
        }
        #endregion

        public abstract void ExpGain(int expGained); //Handles exp gain

        public abstract void LevelUp(); //Handles character levelup

        public abstract void Insult(); //Character attack method

        public abstract void TakeDamage(int damageTaken); //Updates the player's health in battle
        
        //Add Draw()
    }
}
