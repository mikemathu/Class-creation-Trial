using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Ball
{
    internal class Ball
    {
        private int size;
        private int color;
        private int thrown;

        public Ball(int size, int color, int thrown)
        {
            this.size = size;
            this.color = color;
            this.thrown = thrown;
        }

        public int Pop()
        {
            size = 0;
            return size;
        }
        public int Thrown()
        {
            if(size == 0)
                this.thrown += 1;

            return thrown;
        }

        public int Times()
        {

        }
    }
}
