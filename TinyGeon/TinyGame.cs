using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TinyGeon {

    public class TinyGame : Game {

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public TinyGame( ) {
            _graphics             = new GraphicsDeviceManager( this );
            Content.RootDirectory = "Content";
            IsMouseVisible        = true;

            _graphics.PreferredBackBufferWidth  = 1280;
            _graphics.PreferredBackBufferHeight = 720;
        }

        protected override void Initialize( ) {
            base.Initialize( );
        }

        protected override void LoadContent( ) {
            _spriteBatch = new SpriteBatch( GraphicsDevice );
        }

        protected override void Update( GameTime gameTime ) {
        }

        protected override void Draw( GameTime gameTime ) {
            GraphicsDevice.Clear( Color.CornflowerBlue );
        }

    }

}
