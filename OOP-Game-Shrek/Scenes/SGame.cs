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

            //Wall
            ObjectManager.AddObject(new Wall(new Pos(0, 0)));
            ObjectManager.AddObject(new Wall(new Pos(0, 1)));
            ObjectManager.AddObject(new Wall(new Pos(0, 2)));
            ObjectManager.AddObject(new Wall(new Pos(0, 3)));
            ObjectManager.AddObject(new Wall(new Pos(0, 4)));
            ObjectManager.AddObject(new Wall(new Pos(0, 5)));
            ObjectManager.AddObject(new Wall(new Pos(0, 6)));
            ObjectManager.AddObject(new Wall(new Pos(0, 7)));
            ObjectManager.AddObject(new Wall(new Pos(0, 8)));
            ObjectManager.AddObject(new Wall(new Pos(0, 9)));

        }
    }
}
