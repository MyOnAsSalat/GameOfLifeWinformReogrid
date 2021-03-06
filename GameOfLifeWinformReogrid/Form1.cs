﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;

namespace GameOfLifeWinformReogrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size = 60;
        AreaConwayGameOfLife gol = new AreaConwayGameOfLife(60);
        private void Form1_Load(object sender, EventArgs e)
        {
            //AreaConwayGameOfLife R1 = new AreaConwayGameOfLife(10);
            for (int i = 0; i < size; i++)
            {
                Table.CurrentWorksheet.ColumnHeaders[i].Width = 20;
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Show(AreaConwayGameOfLife fields)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int f = 0; f < size; f++)
                {
                    Table.CurrentWorksheet.Cells[i,f].Style.BackColor = fields[i, f] ? Color.Black : Color.White;
                    sum = fields[i, f] ? ++sum : sum;
                }
            }
            Graph(sum);
        }
        int point = 0;
        private void Graph(int sum)
        {
            Graphic.Series[0].Points.AddXY(point, sum);
            point++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Graphic.Series[0].Points.Clear();
            point = 0;
            gol = new AreaConwayGameOfLife(size);
            gol.RandomCells();
            size = Convert.ToInt32(textBox1.Text);
            Table.CurrentWorksheet.ColumnCount = size + 2;
            Table.CurrentWorksheet.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                Table.CurrentWorksheet.Cells[i, size].Style.BackColor = Color.White;
                Table.CurrentWorksheet.Cells[i, size + 1].Style.BackColor = Color.White;
            }
            for (int i = 0; i < size; i++)
            {
                Table.CurrentWorksheet.ColumnHeaders[i].Width = 20;
            }
            
            Table.CurrentWorksheet.SetScale(38f/size);
            timer1.Start();
        }
        int col = 0;     
        private void timer1_Tick(object sender, EventArgs e)
        {           
            gol.Next(1);
            Show(gol);
            Table.CurrentWorksheet.SelectAll();
            Table.CurrentWorksheet.SelectColumns(size + col, size + col);
            col = (col == 0) ? 1 : 0;
        }
        void clear(int size)
        {
            Table.CurrentWorksheet.ColumnCount = size + 2;
            Table.CurrentWorksheet.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                for (int f = 0; f < size; f++)
                {


                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox1.Text);
            timer1.Stop();
   

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
