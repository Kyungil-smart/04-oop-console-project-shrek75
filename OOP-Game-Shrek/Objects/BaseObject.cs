using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek
{
    internal abstract class BaseObject
    {
        //기존위치
        Pos _prevPos;

        //Pos _pos;
        //public Pos Pos
        //{
        //    get { return _prevPos + (_dir * _speed) * 델타타임; }
        //}

        //방향
        Pos _dir;

        //속력
        double _speed;

        //크기
        double _radius;



        public abstract void Update();
        public abstract void Render();

        
    }
}
