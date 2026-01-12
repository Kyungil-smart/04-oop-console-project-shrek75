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
            ObjectManager.AddObject(new MPoop(new Pos(11, 4)));
            ObjectManager.AddObject(new MPoop(new Pos(25, 4)));
            ObjectManager.AddObject(new MRamen(new Pos(3, 5)));
            ObjectManager.AddObject(new MRamen(new Pos(34, 18)));



            //Wall
            // 그냥 하나짜리 벽을만들면되지만 이렇게 해보고싶음
            ObjectManager.AddObject(new Wall(new Pos(0, 0)));
            ObjectManager.AddObject(new Wall(new Pos(1, 0)));
            ObjectManager.AddObject(new Wall(new Pos(2, 0)));
            ObjectManager.AddObject(new Wall(new Pos(3, 0)));
            ObjectManager.AddObject(new Wall(new Pos(4, 0)));
            ObjectManager.AddObject(new Wall(new Pos(5, 0)));
            ObjectManager.AddObject(new Wall(new Pos(6, 0)));
            ObjectManager.AddObject(new Wall(new Pos(0, 1)));
            ObjectManager.AddObject(new Wall(new Pos(1, 1)));
            ObjectManager.AddObject(new Wall(new Pos(2, 1)));
            ObjectManager.AddObject(new Wall(new Pos(3, 1)));
            ObjectManager.AddObject(new Wall(new Pos(4, 1)));
            ObjectManager.AddObject(new Wall(new Pos(5, 1)));
            ObjectManager.AddObject(new Wall(new Pos(6, 1)));

            ObjectManager.AddObject(new Wall(new Pos(33, 23)));
            ObjectManager.AddObject(new Wall(new Pos(34, 23)));
            ObjectManager.AddObject(new Wall(new Pos(35, 23)));
            ObjectManager.AddObject(new Wall(new Pos(36, 23)));
            ObjectManager.AddObject(new Wall(new Pos(37, 23)));
            ObjectManager.AddObject(new Wall(new Pos(38, 23)));
            ObjectManager.AddObject(new Wall(new Pos(39, 23)));
            ObjectManager.AddObject(new Wall(new Pos(33, 22)));
            ObjectManager.AddObject(new Wall(new Pos(34, 22)));
            ObjectManager.AddObject(new Wall(new Pos(35, 22)));
            ObjectManager.AddObject(new Wall(new Pos(36, 22)));
            ObjectManager.AddObject(new Wall(new Pos(37, 22)));
            ObjectManager.AddObject(new Wall(new Pos(38, 22)));
            ObjectManager.AddObject(new Wall(new Pos(39, 22)));
            ObjectManager.AddObject(new Wall(new Pos(33, 21)));
            ObjectManager.AddObject(new Wall(new Pos(34, 21)));
            ObjectManager.AddObject(new Wall(new Pos(35, 21)));
            ObjectManager.AddObject(new Wall(new Pos(36, 21)));
            ObjectManager.AddObject(new Wall(new Pos(37, 21)));
            ObjectManager.AddObject(new Wall(new Pos(38, 21)));
            ObjectManager.AddObject(new Wall(new Pos(39, 21)));




        }
    }
}
