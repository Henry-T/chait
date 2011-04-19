using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace XNANetRun
{
    class GlobalHelper
    {
        #region Instance
        private static GlobalHelper instance;
        public static GlobalHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new GlobalHelper();
                return instance;
            }
        }
        private GlobalHelper()
        {
        }
        #endregion

        public GraphicsDevice GD;
        public ContentManager CM;
        public SpriteBatch SB;
        public SpriteFont SF;

        public void SetGlobalDevice(GraphicsDevice gd, ContentManager cm)
        {
            GD = gd;
            CM = cm;
        }

        public void SetGlobalDraw(SpriteBatch sb)
        {
            SB = sb;
            SF = CM.Load<SpriteFont>("SpriteFont1");
        }
    }
}
