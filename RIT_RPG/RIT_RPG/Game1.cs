#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace RIT_RPG
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        KeyboardState kState;
        MouseState mState;

        #region Game Content
        int gameWidth = 600; // width of the display window
        int gameHeight = 480; // height of the display window
        int buttonWidth = 128;
        int buttonHeight = 64;
        int bMenuHeight = 175;
        Texture2D speechMenuBack; // background for the speech menu
        Texture2D ritLogo; // game logo
        Texture2D newButtonFile; // new button texture
        Texture2D loadButtonFile; // load button texture
        Texture2D mainBackground; // background for the main menu
        Texture2D selectorText; // texture for the battle menu's selector
        Rectangle mouseCursor; // rectangle for clicking on buttons
        Rectangle logo; // The size and position of the logo;
        SpriteFont gameFont; // sprite font for the game (possibly tentative)
        MainMenu titleScreen; // main game screen object
        BattleMenu bMenu; // battle menu
        SpeechMenu sBalloon; // speech menu for the character's dialogue
        Button newButton; // new button drawn to the screen
        Button loadButton; // load button drawn to the screen
        enum MenuState {Main, Battle}
        MenuState gameState = new MenuState();
        #endregion

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            graphics.PreferredBackBufferWidth = gameWidth; // set the width of the game screen to the value entered
            graphics.PreferredBackBufferHeight = gameHeight; // set the height of the game screen to the value entered
            graphics.ApplyChanges(); // without this command, the game window won't be resized

            gameState = MenuState.Main;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            #region Load Textures
            ritLogo = Content.Load<Texture2D>("RITRPGLogo");
            mainBackground = Content.Load<Texture2D>("christmas-snow-background");
            speechMenuBack = Content.Load<Texture2D>("SpeechMenu");
            newButtonFile = Content.Load<Texture2D>("NewGame");
            loadButtonFile = Content.Load<Texture2D>("LoadGame");
            selectorText = Content.Load<Texture2D>("Selector");
            gameFont = Content.Load<SpriteFont>("SpriteFont1");
            #endregion

            #region Create Attributes
            newButton = new Button(graphics, spriteBatch, new Vector2((gameWidth/2) - (buttonWidth / 2), gameHeight - 175), newButtonFile, buttonWidth, buttonHeight);
            loadButton = new Button(graphics, spriteBatch, new Vector2((gameWidth / 2) - (buttonWidth / 2), newButton.Position.Y + buttonHeight + 20), loadButtonFile, buttonWidth, buttonHeight);
            titleScreen = new MainMenu(graphics, spriteBatch, mainBackground, ritLogo, new Vector2(0, 0), gameHeight, gameWidth, newButton, loadButton);
            bMenu = new BattleMenu(graphics, spriteBatch, gameFont, speechMenuBack, selectorText, new Vector2(0, gameHeight - bMenuHeight), bMenuHeight, gameWidth);
            sBalloon = new SpeechMenu(graphics, spriteBatch, gameFont, speechMenuBack, new Vector2(0, gameHeight - bMenuHeight), bMenuHeight, gameWidth);
            #endregion
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            IsMouseVisible = true; // mouse is always visible
            mState = Mouse.GetState();
            // set a teeny tiny rectangle to follow the mouse's cursor
            mouseCursor = new Rectangle(mState.Position.X, mState.Position.Y, 1, 1);

            switch (gameState)
            {
                case MenuState.Main:
                    // go to battle mode if the new game button is clicked
                    if(mState.LeftButton == ButtonState.Pressed && mouseCursor.Intersects(newButton.ButtonBox))
                    {
                        gameState = MenuState.Battle;
                    }
                    break;
                case MenuState.Battle:
                    bMenu.ProcessInput(); // this method handles the keyboard input for the battle menu
                    break;
                default:
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            switch (gameState)
            {
                case MenuState.Main:
                    titleScreen.DrawMenu();
                    break;
                case MenuState.Battle:
                    // add the drawing code for other elements of the battle here
                    bMenu.DrawMenu();
                    break;
                default:
                    break;
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
