using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Objects
{
    internal class OTestObj : BaseObject
    {
        public OTestObj(Pos pos)
        {
            _pos = pos;
            _sprite = new Utils.Sprite(
                new char[,] {
                    { '#', '#', '#', '#' },
                    { '#', ' ', ' ', '#' },
                    { '#', ' ', ' ', '#' },
                    { '#', '#', '#', '#' }});
        }

        public override void Update()
        {
            if(_pos._y == 3)
            {
                base._speed = 1.0;
                base._dir = new Pos(1, 0);
            }
            if(_pos._y == 5)
            {
                base._speed = 1.0;
                base._dir = new Pos(-1, 0);
            }

            _pos = _pos + (_dir * _speed) * TimeManager.LogicTime;
        }
        public override void Render()
        {
            _sprite.Render(RenderPos);
        }

    }
}
