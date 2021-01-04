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

        public int getLength() { return length; }
        public int getWidth() { return width; }
        public int getCount() { return count; }

        public void increment() { count++; }

        public void decrement() { count--; }
    }
}
