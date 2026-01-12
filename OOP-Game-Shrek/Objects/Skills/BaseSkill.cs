using OOP_Game_Shrek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Objects.Skills
{
    internal abstract class BaseSkill : BaseObject, ICollision
    {
        //데미지랑 타이머도 있어야하는데
        protected double _damage = 1;
        protected int _lifeTime = (int)(0.5 * TimeManager.GAME_TPS);

        //스킬에 맞은 몬스터를 기록. (중복데미지 방지 + 한번에때릴수있는 몹수제한)
        protected List<BaseObject> _targets = new List<BaseObject>();
        protected int _maxTargetNums = 1;

        public BaseSkill(Pos pos)
        {
            _isInvincible = true;
            _pos = pos;
            //_sprite는 하위클래스에서 구현

        }

        public abstract void OnCollision(BaseObject otherObj);

        public override void Update()
        {
            _lifeTime--;
            if (_lifeTime < 0)
                ObjectManager.DeleteObject(this);

        }
    }
}
