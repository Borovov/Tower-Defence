using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StarBoy.Code;
using System.Collections.Generic;

namespace StarBoy
{
    public class Main : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameSet gameSet = GameSet.towerDefence;
        public int[,] Layer;
        MapSetter mapSetter = new MapSetter();
        List<Bush> Bushes = new List<Bush>();
        List<Road> Roads = new List<Road>();
        List<Soldier> Soldiers = new List<Soldier>();

        Texture2D backgroundTex, bushTex, roadTex;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 960;
            graphics.PreferredBackBufferHeight = 640;

            Layer = mapSetter.getLayer();

            this.IsMouseVisible = true;
            graphics.ApplyChanges();
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundTex = Content.Load<Texture2D>("Sprites/background");
            bushTex = Content.Load<Texture2D>("Sprites/bush");
            roadTex = Content.Load<Texture2D>("Sprites/road");

            mapSetter.fillLayer(Bushes, bushTex, Roads, roadTex);
        }
        
        protected override void UnloadContent()
        {
            
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            switch (gameSet)
            {
                case GameSet.menu:

                    break;

                case GameSet.inputName:

                    break;

                case GameSet.towerDefence:

                    break;

                case GameSet.backpack:

                    break;

                case GameSet.death:

                    break;

                case GameSet.victory:

                    break;
            }

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            switch (gameSet)
            {
                case GameSet.menu:

                    break;

                case GameSet.inputName:

                    break;

                case GameSet.towerDefence:
                    spriteBatch.Draw(backgroundTex, new Rectangle(0, 0, 960, 640), Color.White);

                    for (int i = 0; i < Bushes.Count; i++)
                        spriteBatch.Draw(Bushes[i].tex, Bushes[i].pos, Color.White);

                    for (int i = 0; i < Roads.Count; i++)
                        spriteBatch.Draw(Roads[i].tex, Roads[i].pos, Color.White);

                    for (int i = 0; i < Soldiers.Count; i++)
                        spriteBatch.Draw(Soldiers[i].tex, Soldiers[i].pos, Color.White);
                    break;

                case GameSet.backpack:

                    break;

                case GameSet.death:

                    break;

                case GameSet.victory:

                    break;
            }
            
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
