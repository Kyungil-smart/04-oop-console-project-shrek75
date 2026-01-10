using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek
{
    // User Input을 담당하는 클래스
    // 어떻게 만들까 많이 고민했지만.. 일단 가장 간단한 방향으로
    internal static class InputManager
    {
        // Poll()마다 inputKey를 담을 hashSet 
        static HashSet<ConsoleKeyInfo> _keys = new HashSet<ConsoleKeyInfo>();
        // readonly hashSet
        public static IReadOnlyCollection<ConsoleKeyInfo> Keys { get { return _keys; } }

        // 입력한 키가 있으면 _keys에 넣어준다.
        public static void Poll()
        {
            while(Console.KeyAvailable)
            {
                ConsoleKeyInfo _key = Console.ReadKey();
                _keys.Add(_key);
            }
        }

        public static void Clear()
        {
            _keys.Clear();
        }
    }
}
