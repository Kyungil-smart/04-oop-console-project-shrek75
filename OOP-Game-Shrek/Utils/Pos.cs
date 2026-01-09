using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game_Shrek
{
    internal struct Pos
    {
        public double X;
        public double Y;

        // 크기 1짜리 방향벡터 반환.  인텔리센스 왤캐 좋아;;
        public static Pos GetDirVector(Pos from, Pos to)
        {
            double dx = to.X - from.X;
            double dy = to.Y - from.Y;
            double length = Math.Sqrt(dx * dx + dy * dy);
            if (length == 0)
            {
                return new Pos { X = 0, Y = 0 };
            }
            return new Pos { X = dx / length, Y = dy / length };
        }


        // 더하기 연산자 오버로딩
        public static Pos operator +(Pos a, Pos b)
        {
            return new Pos { X = a.X + b.X, Y = a.Y + b.Y };
        }

        // 곱하기 연산자 오버로딩
        public static Pos operator *(Pos pos, double d)
        {
            return new Pos { X = pos.X * d, Y = pos.Y * d };
        }
        public static Pos operator *(double d, Pos pos)
        {
            return new Pos { X = pos.X * d, Y = pos.Y * d };
        }
        public static Pos operator *(Pos pos, int i)
        {
            return new Pos { X = pos.X * i, Y = pos.Y * i };
        }
        public static Pos operator *(int i, Pos pos)
        {
            return new Pos { X = pos.X * i, Y = pos.Y * i };
        }
    }
}
