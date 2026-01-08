using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek
{
    internal static class SceneManager
    {
        private static bool _quitRequested = false; // 게임종료 요청 플래그
        private static BaseScene _currentScene;     // 현재 실행중인 Scene
        private static BaseScene _previousScene;    // 이전에 실행되었던 Scene

        /// <summary>
        /// SceneManager 에게 게임종료를 요청합니다.
        /// </summary>
        public static void RequestQuit()
        {
            _quitRequested = true;
        }

        /// <summary>
        /// SceneManager 가 Scene을 실행합니다.<br/>
        /// 유저의 Input 처리, 객체들의 Update 와 Render 가 포함됩니다.
        /// </summary>
        public static bool Run()
        {
            if (_quitRequested) return false;
            return true;
        }
    }
}
