using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNANetServer.Role
{
    class RoleManager
    {
        #region Variavles
        private Dictionary<String, ServerRole> roleDic;
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
            // 计算新的位置
        }
        public void TellClients()
        {
            // 将新的位置发送给客户端
        }

        public void Draw()
        {

        }
        #endregion

        #region Role Manager
        public void AddRole(String roleName)
        {
            if(roleDic.Keys.Contains(roleName))
            {
                // ...
                return;
            }
            else
            {
                ServerRole sr = new ServerRole();
                sr.Name = roleName;
                sr.X = 100;
                sr.Y = 100;
                roleDic.Add(roleName, sr);
            }
        }
        #endregion
    }
}
