using OOP_Game_Shrek.Scenes;
using OOP_Game_Shrek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Objects
{
    internal class Wall : BaseObject, ICollision
    {
        public Wall(Pos pos)
        {
            base._pos = pos;
            string[,] s = new string[,] { { "⛰️" } };
            base._sprite = new Utils.Sprite(s);
            base._isInvincible = true;
        }

        public void OnCollision(BaseObject otherObj)
        {
            Log.Push(Log.LogType._WARN, $"{base.GetType()} x{Pos._x}y{Pos._y}");
            otherObj.MovePos(base.LastPos);
        }

        public override void Update()
        {

        }
    }
}
