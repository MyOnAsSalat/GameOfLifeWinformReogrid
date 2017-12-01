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
        protected bool[,] Cells;
        public int Size { get { return Cells.GetLength(0) * Cells.GetLength(1); } }
        public int SizeX { get { return Cells.GetLength(0); } }
        public int SizeY { get { return Cells.GetLength(1); } }
        //public Area() { throw  new Exception("Cells = null"); }
        //Конструктор поля с заданными клетками      
        public Area(bool[,] cells)
        {
            this.Cells = cells;
        }
        //Конструктор квадратного поля с заданным размером
        public Area(int size)
        {
            Cells = new bool[size, size];
        }
        //Конструктор прямоугольного поля
        public Area(int sizeX, int sizeY)
        {
            Cells = new bool[sizeX, sizeY];
        }
        //индексатор для получения клетки из поля
        public bool this[int x, int y]
        {
            get
            {
                return Cells[indexX(x), indexY(y)];
            }
            set
            {
                Cells[indexX(x), indexY(y)] = value;
            }
        }
        //Заполнение и очиста клеток
        public void Fill()
        {
            for (int i = 0; i < SizeX; i++)
            {
                for (int f = 0; f < SizeY; f++)
                {

                    Cells[i, f] = true;
                }
            }
        }
        public void Clear()
        {
            for (int i = 0; i < SizeX; i++)
            {
                for (int f = 0; f < SizeY; f++)
                {

                    Cells[i, f] = false;
                }
            }
        }
        // Получение цикличного индекса вычетом по модулю
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int indexX(int i)
        {
            return i < 0 ? SizeX - Math.Abs(i % SizeX) : i % SizeX;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int indexY(int i)
        {
            return i < 0 ? SizeY - Math.Abs(i % SizeY) : i % SizeY;
        }
        //Заполнение поля рандомными клетками
        public virtual void RandomCells()
        {
            Cells = new bool[SizeX, SizeY];
            for (int i = 0; i < SizeX; i++)
            {
                for (int f = 0; f < SizeY; f++)
                {

                    Cells[i, f] = rng();
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
        //следующая генерация      
        public virtual void Next()
        {
            RandomCells();
        }
        public virtual void Next(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Next();
            }
        }
    }
}
