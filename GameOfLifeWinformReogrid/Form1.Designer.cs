﻿namespace GameOfLifeWinformReogrid
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Table = new unvell.ReoGrid.ReoGridControl();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.BackColor = System.Drawing.Color.White;
            this.Table.ColumnHeaderContextMenuStrip = null;
            this.Table.LeadHeaderContextMenuStrip = null;
            this.Table.Location = new System.Drawing.Point(2, -2);
            this.Table.Name = "Table";
            this.Table.RowHeaderContextMenuStrip = null;
            this.Table.Script = null;
            this.Table.SheetTabContextMenuStrip = null;
            this.Table.SheetTabNewButtonVisible = true;
            this.Table.SheetTabVisible = true;
            this.Table.SheetTabWidth = 60;
            this.Table.ShowScrollEndSpacing = true;
            this.Table.Size = new System.Drawing.Size(539, 726);
            this.Table.TabIndex = 0;
            this.Table.Text = "reoGridControl1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(655, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "StartRandom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(560, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100";
            // 
            // Graphic
            // 
            this.Graphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Graphic.BackColor = System.Drawing.Color.Transparent;
            this.Graphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Graphic.BorderlineColor = System.Drawing.Color.Transparent;
            this.Graphic.BorderlineWidth = 0;
            this.Graphic.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.Graphic.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Graphic.BorderSkin.BackSecondaryColor = System.Drawing.Color.Black;
            this.Graphic.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Graphic.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Graphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graphic.Legends.Add(legend1);
            this.Graphic.Location = new System.Drawing.Point(560, 54);
            this.Graphic.Margin = new System.Windows.Forms.Padding(0);
            this.Graphic.Name = "Graphic";
            this.Graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.BackSecondaryColor = System.Drawing.Color.Black;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            this.Graphic.Series.Add(series1);
            this.Graphic.Size = new System.Drawing.Size(734, 439);
            this.Graphic.TabIndex = 3;
            this.Graphic.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(774, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "ClearEdite";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(893, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "StartEdite";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 722);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Graphic);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private unvell.ReoGrid.ReoGridControl Table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

