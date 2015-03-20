using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Using file input and output

namespace CharacterEditor
{
    public partial class CharacterEditor : Form
    {
        public CharacterEditor()
        {
            InitializeComponent();
        }

        private void CreateCharacterButton_Click(object sender, EventArgs e) //When the button to create the character is pressed
        {
            StreamWriter fileWriter = null; //Create the StreamWriter object
            int humor = 0; //Create an int to hold the value of humor
            bool humorBool = int.TryParse(HumorTextBox.Text, out humor); //Try to parse user input for humor
            int inteligence = 0; //Create an int to hold the value of inteligence
            bool inteligenceBool = int.TryParse(InteligenceTextBox.Text, out inteligence); //Try to parse user input for inteligence
            int energy = 0; //Create an int to hold the value of energy
            bool energyBool = int.TryParse(EnergyTextBox.Text, out energy); //Try to parse user input for energy
            int wit = 0; //Create an int to hold the value of wit
            bool witBool = int.TryParse(WitTextBox.Text, out wit); //Try to parse user input for wit

            if (CharacterNameTextBox.Text != "") //If the user entered a name for the character
            {
                if (humorBool == true && inteligenceBool == true && energyBool == true && witBool == true) //If the user entered numbers for all of the stats
                {
                    //SmartassGuy Code
                    if (SmartassGuyButton.Checked == true) //If you are creating a Smartass Guy
                    {
                        try //Try to create the file
                        {
                            fileWriter = new StreamWriter("..\\..\\..\\..\\smartassGuy.bin"); //Filename
                            WriteProgressBar.Value = 50; //Increment the progress bar
                        }
                        catch (IOException) //If there is an IOException
                        {
                            MessageBox.Show("There was a problem creating the character file!"); //Display the exception message
                        }
                        catch (Exception) //If there is any other exception
                        {
                            MessageBox.Show("There was a problem creating the character file!\nBut we're not sure what it is."); //Display the exception message
                        }

                        if (IncreaseHumorButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseInteligenceButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseEnergyButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseWitButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Smartass Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 3); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                    }


                    //LowJokesGuy Code
                    if (LowJokesGuyButton.Checked == true) //If you are creating a Smartass Guy
                    {
                        try //Try to create the file
                        {
                            fileWriter = new StreamWriter("..\\..\\..\\..\\lowjokesGuy.bin"); //Filename
                            WriteProgressBar.Value = 50; //Increment the progress bar
                        }
                        catch (IOException) //If there is an IOException
                        {
                            MessageBox.Show("There was a problem creating the character file!"); //Display the exception message
                        }
                        catch (Exception) //If there is any other exception
                        {
                            MessageBox.Show("There was a problem creating the character file!\nBut we're not sure what it is."); //Display the exception message
                        }

                        if (IncreaseHumorButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseInteligenceButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseEnergyButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseWitButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Low Jokes Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                    }


                    //WittyGuy Code
                    if (WittyGuyButton.Checked == true) //If you are creating a Smartass Guy
                    {
                        try //Try to create the file
                        {
                            fileWriter = new StreamWriter("..\\..\\..\\..\\wittyGuy.bin"); //Filename
                            WriteProgressBar.Value = 50; //Increment the progress bar
                        }
                        catch (IOException) //If there is an IOException
                        {
                            MessageBox.Show("There was a problem creating the character file!"); //Display the exception message
                        }
                        catch (Exception) //If there is any other exception
                        {
                            MessageBox.Show("There was a problem creating the character file!\nBut we're not sure what it is."); //Display the exception message
                        }

                        if (IncreaseHumorButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseInteligenceButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseEnergyButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 + 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseWitButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Witty Guy"); //Write the character's class
                                    fileWriter.WriteLine(100); //Add the character's ego stat
                                    fileWriter.WriteLine(humor + 3); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                    }


                    //CoffeeGuy Code
                    if (CoffeeGuyButton.Checked == true) //If you are creating a Smartass Guy
                    {
                        try //Try to create the file
                        {
                            fileWriter = new StreamWriter("..\\..\\..\\..\\coffeeGuy.bin"); //Filename
                            WriteProgressBar.Value = 50; //Increment the progress bar
                        }
                        catch (IOException) //If there is an IOException
                        {
                            MessageBox.Show("There was a problem creating the character file!"); //Display the exception message
                        }
                        catch (Exception) //If there is any other exception
                        {
                            MessageBox.Show("There was a problem creating the character file!\nBut we're not sure what it is."); //Display the exception message
                        }

                        if (IncreaseHumorButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 + 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseInteligenceButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5 - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence + 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseEnergyButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 + 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                        if (IncreaseWitButton.Checked == true) //If you are increasing humor
                        {
                            if (DecreaseHumorButton.Checked == true) //If you are decreasing humor
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5 - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseInteligenceButton.Checked == true) //If you are decreasing inteligence
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence - 5); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseEnergyButton.Checked == true) //If you are decreasing energy
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3 - 5); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                            if (DecreaseWitButton.Checked == true) //If you are decreasing wit
                            {
                                try //Try to write to the file
                                {
                                    fileWriter.WriteLine(CharacterNameTextBox.Text); //Write the character's name
                                    fileWriter.WriteLine("Coffee Guy"); //Write the character's class
                                    fileWriter.WriteLine(100 + 5); //Add the character's ego stat
                                    fileWriter.WriteLine(humor - 5); //Add the character's humor stat
                                    fileWriter.WriteLine(inteligence); //Add the character's inteligence stat
                                    fileWriter.WriteLine(energy + 3); //Add the character's energy stat
                                    fileWriter.WriteLine(wit + 5 - 5); //Add the character's wit stat

                                    WriteProgressBar.Value = 100; //Increment the progress bar
                                    MessageBox.Show("Character created!"); //Tell the user the character has been created
                                }
                                catch (IOException) //If there is an IOException
                                {
                                    MessageBox.Show("There was an error writing to the file!"); //Display the exception message
                                }
                                catch (Exception) //If there is any other exception
                                {
                                    MessageBox.Show("There was an error writing to the file!\nBut we're not sure what it is."); //Display the exception message
                                }
                            finally //Runs every time
                                {
                                    fileWriter.Close(); //Close the StreamWriter
                                }
                            }
                        }
                    }
                }
                else //If the user did not enter numbers for the character's stats
                {
                    MessageBox.Show("You must enter numbers for the character's stats!"); //Yell at the user
                }
            }
            else //If the user did not enter a name for the character
            {
                MessageBox.Show("You must enter a name for the character!"); //Yell at the user
            }
        }
    }
}
