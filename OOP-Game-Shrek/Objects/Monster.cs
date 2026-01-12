using OOP_Game_Shrek.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Objects
{
    //일단 상위클래스 만들어야할것같아서 만든 몬스터클래스
    internal abstract class Monster : BaseObject, ICollision
    {
        //몸박뎀
        protected int _bodyDamage = 5;
        //몸박뎀 쿨타임 (근데 이런식으로 만들면 메이플처럼 쿨타임이 섭렉영향받는구나. 섭렉은아니지만..)
        protected int _bodyDamageCoolDown = (int)(1 * TimeManager.GAME_TPS); //1초
        protected int _bodyDamageCalcuation = (int)(1 * TimeManager.GAME_TPS);//일단 이거 Update마다 -- 하는걸로
        //몸박뎀 사용가능여부(이거 그냥 스킬정보struct를 만들어야겟는데)
        protected bool _bodyDamageUsable = true;

        //플레이어 추적여부
        protected bool _trackPlayer = false;

        //Monster클래스 기본 Update. 
        public override void Update()
        {
            Move();
        }

        public override void Render()
        {
            base.Render();
            DrawHP();
        }

        //추상메서드로 ICollision 구현
        public abstract void OnCollision(BaseObject otherObj);
    }
}
