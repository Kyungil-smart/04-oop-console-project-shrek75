using OOP_Game_Shrek.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek.Scenes
{
    internal class SGame : BaseScene
    {
        public SGame()
        {
            
        }

        public override void Init()
        {
            ObjectManager.AddObject(new StageManager());
        }

    }
}
