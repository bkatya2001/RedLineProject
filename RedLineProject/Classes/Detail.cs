using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLineProject.Classes
{
    class Detail // Класс коллекции детали одного вида
    {
        int length;
        int width;
        int count;

        public Detail(int _length, int _width, int _count)
        {
            length = _length;
            width = _width;
            count = _count;
        }

        public int GetLength() { return length; }
        public int GetWidth() { return width; }
        public int GetCount() { return count; }

        public void Increment() { count++; }

        public void Decrement() { count--; }

        public static int CompareDetails(Detail x, Detail y)
        {
            int xS = x.GetLength() * x.GetWidth();
            int yS = y.GetLength() * y.GetWidth();
            if (xS > yS) return -1;
            if (xS == yS) return 0;
            if (xS < yS) return 1;
            return 0;
        }
    }
}
