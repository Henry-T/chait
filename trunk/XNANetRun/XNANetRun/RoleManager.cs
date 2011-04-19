using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XNANetRun
{
    class RoleManager
    {
        #region Variavles
        private Dictionary<String, Role> roleDic = new Dictionary<string,Role>();
        #endregion

        #region Instance
        private static RoleManager instance;
        public static RoleManager Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new RoleManager();
                }
                return instance;
            }
        }
        private RoleManager()
        {
        }
        #endregion

        #region Update & Draw
        public void Update()
        {
            // 执行本地更新
        }

        public void Draw()
        {
            foreach (Role r in roleDic.Values)
            {
                r.Draw();
            }
        }
        #endregion

        #region Role Manager
        public void OnJoinHandler(String roleName)
        {
            tryCreateRole(roleName);
        }
        private void tryCreateRole(String roleName)
        {
            if (roleDic.Keys.Contains(roleName))
            {
                // ...
                return;
            }
            else
            {
                Role sr = new Role();
                sr.Name = roleName;
                sr.X = 100;
                sr.Y = 100;
                roleDic.Add(roleName, sr);
            }
        }

        public void onNeckListHandler(List<String> neckList)
        {
            foreach (String s in neckList)
            {
                tryCreateRole(s);
            }
        }

        public void OnRolePosHandler(String neckname, int x, int y)
        {
            x = (int)MathHelper.Clamp(x, 0, 800);
            y = (int)MathHelper.Clamp(y, 0, 600);
            // 改变脸的方向
            if (Math.Abs(roleDic[neckname].X - x) > 3)
            {
                if (roleDic[neckname].X > x)
                {
                    roleDic[neckname].FaceRight = false;
                }
                else
                {
                    roleDic[neckname].FaceRight = true;
                }
            }
            roleDic[neckname].X = x;
            roleDic[neckname].Y = y;
        }
        #endregion
    }
}
