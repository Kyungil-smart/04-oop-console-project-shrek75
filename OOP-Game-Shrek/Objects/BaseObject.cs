using OOP_Game_Shrek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek
{
    internal abstract class BaseObject
    {
        //객체의 정중앙 위치
        public Pos _pos;

        //방향
        public Pos _dir;

        //속력
        public double _speed;

        //객체의 외형과 크기
        public Sprite _sprite;

        //Render를 위한 위치반환
        public Pos RenderPos { get { return _pos + (_dir * _speed) * TimeManager.DeltaTime; } }

        public abstract void Update();
        public abstract void Render();

        
    }
}
