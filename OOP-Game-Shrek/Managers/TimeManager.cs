using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek
{
    internal class TimeManager
    {
        private const int GAME_TPS = 30; // 게임의 초당 Update 호출 주기
        private const long AVERAGE_TICKS = 10000000 / GAME_TPS; 
        
        //private long _gameLogicCount = 0; // 현재 Update 횟수
        //private long _lastGameLogicCount = 0; // 1초전 Update 횟수

        //private long _FrameCount = 0; // 렌더링된 전체 프레임 수
        //private long _lastFrameCount = 0; // 1초전 프레임 수

        int _updateTimes; //이번 루프에서 Update 가 몇 번 호출되어야 하는지

        long _deltaTickPerUpdate = 0; // 업데이트 당 delta tick
        long _deltaTick = 0; // 마지막 프레임과의 tick 차이

        long _lastTick = 0; // 마지막에 기록된 stopwatch tick
        long _nowTick = 0;  // 현재 stopwatch tick

        Stopwatch _timePerFrame;


        /// <summary>
        /// 이번 루프에서 Update 가 몇 번 호출되어야 하는지 반환합니다.
        /// </summary>
        public int GetUpdateTimes()
        {
            // deltaTick 기록
            _nowTick += _timePerFrame.ElapsedTicks;
            _deltaTick = _nowTick - _lastTick;

            // 몇번 Update 해야하는지 계산
            _updateTimes = (int)(_deltaTick / AVERAGE_TICKS);

            // update만 너무 많이 호출되는 걸 방지
            if (_updateTimes > 10) _updateTimes = 10;

            // 렌더링이 오래걸려서 Update가 여러번 호출되어야 하는 경우를 위해 Update 당 deltaTick 계산
            // 및 _lastTick 갱신
            if (_updateTimes != 0)
            {
                _deltaTickPerUpdate = _deltaTick / _updateTimes;
                _lastTick += _deltaTickPerUpdate * _updateTimes;
            }
            else
            {
                _deltaTickPerUpdate = _deltaTick;
                _lastTick = _nowTick;
            }

            return _updateTimes;
        }

       
        
    }
}
