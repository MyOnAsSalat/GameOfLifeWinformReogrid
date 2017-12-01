using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeWinformReogrid
{
    class AreaConwayGameOfLife : Area
    {
        public AreaConwayGameOfLife(int size) : base(size) { }
        public AreaConwayGameOfLife(int sizeX,int sizeY) : base(sizeX,sizeY) { }
        public AreaConwayGameOfLife(bool[,] cells) : base (cells) { }
        public override void Next()
        {
            bool[,] BufferCells = new bool[SizeX, SizeY];
            for (int i = 0; i < SizeX; i++)
            {
                for (int f = 0; f < SizeY; f++)
                {
                    int sum = 0; //сумма клетом вокруг клетки по индексу i f
                    sum = this[i - 1, f - 1] ? ++sum : sum;
                    sum = this[i - 1, f + 1] ? ++sum : sum;
                    sum = this[i - 1, f] ? ++sum : sum;
                    sum = this[i + 1, f - 1] ? ++sum : sum;
                    sum = this[i + 1, f + 1] ? ++sum : sum;
                    sum = this[i + 1, f] ? ++sum : sum;
                    sum = this[i, f - 1] ? ++sum : sum;
                    sum = this[i, f + 1] ? ++sum : sum;
                    if (sum == 2) { BufferCells[i, f] = this[i, f]; continue; }
                    BufferCells[i, f] = (sum == 3) ? true : false;
                }
            }
            Cells = BufferCells;
        }
    }
}
