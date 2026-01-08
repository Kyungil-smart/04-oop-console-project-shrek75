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
        private const int GAME_TPS = 30; // 게임의 Update 호출 주기
        private const long AVERAGE_TICKS = 10000000 / GAME_TPS; 
        

        private long _GametickCount = 0; // 전체 틱 수
        private long _lastGameTickCount = 0; // 1초전 틱 수
        
        private long _FrameCount = 0; // 렌더링된 전체 프레임 수
        private long _lastFrameCount = 0; // 1초전 프레임 수


        long _deltaTick = 0; // 마지막 프레임과의 tick 차이
        long _lastTick = 0;
        long _nowTick = 0;

        Stopwatch _timePerFrame;
        

        private void Report()
        {
            _nowTick += _timePerFrame.ElapsedTicks;
            _deltaTick = _nowTick - _lastTick;
            _lastTick = _nowTick;

        }

        public int GetNumberOfUpdates()
        {
            
        }
        
    }
}
