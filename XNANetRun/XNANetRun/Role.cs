using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XNANetRun
{
    class Role
    {
        // public const int Speed = ;    // 速度由服务器控制,客户端的速度用于显示平滑处理

        public Texture2D Texture = GlobalHelper.Instance.CM.Load<Texture2D>("role");
        public String Name;
        public int X = 100;
        public int Y = 100;
        public int TargetX = 100;
        public int TargetY = 100;
        public bool FaceRight = true;

        public void Update()
        {
        }

        public void Draw()
        {
            GlobalHelper.Instance.SB.DrawString(GlobalHelper.Instance.SF, Name, new Vector2(X - 10, Y - Texture.Height -15), Color.Red);
            GlobalHelper.Instance.SB.Draw(
                Texture,
                new Vector2(X, Y),
                null,
                Color.White, 
                0,
                new Vector2(Texture.Width / 2, Texture.Height),
                1,
                FaceRight?SpriteEffects.FlipHorizontally:SpriteEffects.None,
                0);
        }
    }
}
