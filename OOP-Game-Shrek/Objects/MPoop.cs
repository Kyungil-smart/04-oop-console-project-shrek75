using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Objects
{
    internal class MPoop : Monster
    {
        public MPoop(Pos pos)
        {
            // 위치
            _pos = pos;

            // 외형 
            char[,] s = new char[,] { { '♨' } };
            _sprite = new Utils.Sprite(s);

            // 속력
            _speed = 2;

            // 방향
            _dir = new Pos(0, 0);
   
        }

        public override void Update()
        {
            
            //Player와의 거리가 10이하가 되면 추적상태 ON 
            if(_trackPlayer) _dir = ObjectManager.GetDirVectorToPlayer(this.Pos);
            else if(ObjectManager.GetDistanceToPlayer(this.Pos) < 10)
            {
                base._trackPlayer = true;
            }
            Move();

        }
        


    }
}
