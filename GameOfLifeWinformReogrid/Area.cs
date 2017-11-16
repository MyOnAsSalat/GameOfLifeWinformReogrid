using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeWinformReogrid
{
    class Area
    {
        bool[,] Cells;
        public int Size { get { return Convert.ToInt32(Math.Sqrt(Cells.Length)); } }
        //Конструктор поля с заданными клетками
        public Area(bool[,] cells)
        {
            this.Cells = cells;
        }
        //Конструктор поля с заданным размером
        public Area(int size)
        {
            RandomCells(out Cells, size);
        }
        //индексатор для получения клетки из поля
        public bool this[int x, int y]
        {
            get
            {
                return Cells[index(x), index(y)];
            }
            set
            {
                Cells[index(x), index(y)] = value;
            }
        }
        // Получение цикличного индекса вычетом по модулю
        private int index(int i)
        {
            return i < 0 ? Size - Math.Abs(i % Size) : i % Size;
        }
        //Заполнение поля рандомными клетками
        void RandomCells(out bool[,] cells, int size)
        {
            cells = new bool[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int f = 0; f < size; f++)
                {

                    cells[i, f] = rng();
                }
            }
            bool rng()
            {
                int randomvalue;
                using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
                {
                    byte[] rno = new byte[5];
                    rg.GetBytes(rno);
                    randomvalue = BitConverter.ToInt32(rno, 0);
                }
                return randomvalue % 2 == 0 ? true : false;
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Next()
        {
            bool[,] BufferCells = new bool[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int f = 0; f < Size; f++)
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
