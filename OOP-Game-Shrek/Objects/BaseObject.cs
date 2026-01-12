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
        protected Pos _pos = new Pos(10,10);
        public Pos Pos { get { return _pos; } }

        //방향
        protected Pos _dir = new Pos(0,0);

        //속력
        protected double _speed = 0;

        //객체의 외형과 크기
        public Sprite _sprite;

        //체력
        private double _hp;
        public double HP
        {
            get { return _hp; }
            set
            {
                _hp = value;
                if(_hp <= 0)
                {
                    _IsDead = true;
                }
            }
        }

        //죽었는지
        private bool _IsDead = false;
        public bool IsDead { get { return _IsDead; } }

        public abstract void Update();

        //BaseObject 기본 Render
        public virtual void Render()
        {
            _sprite?.Render(RenderPos);
        }

        //Render를 위한 위치반환
        protected Pos RenderPos { get { return _pos + (_dir * _speed) * TimeManager.DeltaTime; } }

        //Update에서 오브젝트위치 갱신용 Move
        public virtual void Move()
        {
            _pos = _pos + (_dir * _speed) * TimeManager.LogicTime;
        }

        public virtual void Damage(double attackPower)
        {
            HP -= attackPower;
        }


        
    }
}
