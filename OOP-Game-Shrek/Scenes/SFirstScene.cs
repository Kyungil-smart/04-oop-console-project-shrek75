using OOP_Game_Shrek.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Scenes
{
    //SceneManager가 가장 먼저 활성화하는 Scene
    internal class SFirstScene : BaseScene
    {
        public SFirstScene()
        {
            ObjectManager.AddObject(new DummyObject()); //로그 오브젝트

            SceneManager.ChangeScene<STitle>();
        }
    }
}
