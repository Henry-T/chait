using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using ChaitAppClient;
using System.Net;

namespace XNANetRun
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class XNANetClientGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public XNANetClientGame()
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
            GlobalHelper.Instance.SetGlobalDevice(graphics.GraphicsDevice, Content);

            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            graphics.ApplyChanges();

            lastMouseState = Mouse.GetState();
            IsMouseVisible = true;

            Random r = new Random(DateTime.Now.Millisecond);
            String ip = Dns.GetHostAddresses(Environment.MachineName)[0].ToString();
            ChaitClient.Instance.Join(IPAddress.Parse(ip), 1048, r.Next(9999).ToString(), IPAddress.Parse("111.0.240.61"));
            ChaitClient.Instance.OnJoinEvent += RoleManager.Instance.OnJoinHandler;
            ChaitClient.Instance.OnNeckListEvent += RoleManager.Instance.onNeckListHandler;
            ChaitClient.Instance.OnRolePosEvent += RoleManager.Instance.OnRolePosHandler;

            ChaitClient.Instance.NeckList();
            base.Initialize();
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
            GlobalHelper.Instance.SetGlobalDraw(spriteBatch);
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
        private MouseState lastMouseState;
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            // 鼠标单击时向服务器发送移动目标信息
            MouseState ms = Mouse.GetState();
            if (ms.LeftButton == ButtonState.Pressed &&
                lastMouseState.LeftButton == ButtonState.Released)
            {
                ChaitClient.Instance.SetTarget(ms.X, ms.Y);
            }
            lastMouseState = ms;

            RoleManager.Instance.Update();

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
            RoleManager.Instance.Draw();
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
