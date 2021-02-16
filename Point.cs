using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeijka
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        private Point tail;

        public Point()
        {
            
        }

        public Point(Point tail)
        {
            this.tail = tail;
        }

        internal void Move(int i, Direction direction)
        {
            throw new NotImplementedException();
        }

        public Point(int _x,int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);//вывод точки на экран 
            Console.Write(sym); // вызвать символ  который вы задали
        }
    }
}
