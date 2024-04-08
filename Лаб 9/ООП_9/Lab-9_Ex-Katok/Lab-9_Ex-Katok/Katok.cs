using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab_9_Ex_Katok
{
    
    public partial class Katok : UserControl
    {
        public List<color> colors = new List<color>();
        private void Katok_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("colors.json", FileMode.OpenOrCreate))
            {
                colors = JsonSerializer.Deserialize<List<color>>(fs);
            }
        }
        public Point[] point;
        private int[] dx, dy;
        private Random rand = new Random();
        private int n;
        public Katok(int N)
        {
            InitializeComponent();
            n = N;
            point = new Point[n];
            dx = dy = new int[n];
            for (int i = 0; i < n; i++)
            {
                point[i].X = rand.Next(Width);
                point[i].Y = rand.Next(Height);
                do { dx[i] = rand.Next(6) - 3; } while (dx[i] == 0);
                do { dy[i] = rand.Next(6) - 3; } while (dy[i] == 0);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                point[i].X += dx[i];
                point[i].Y += dy[i];
                if ((point[i].X < 3) || (point[i].X > Width - 3))
                    dx[i] = -dx[i];
                if ((point[i].Y < 3) || (point[i].Y > Height - 3))
                    dy[i] = -dy[i];
                if (point[i].X > Width - 3) point[i].X = Width - 3;
                if (point[i].Y > Height - 3) point[i].Y = Height - 3;

            }
            Invalidate();
        }

        private void Katok_Paint(object sender, PaintEventArgs e)
        {
            Random rand = new Random();

            color lineColor = colors[rand.Next(0, 99)];
            Pen pen = new Pen(lineColor.getColor());
            pen.Width += 3;

            e.Graphics.DrawPolygon(pen, point);

            color bgColor;
            bgColor = colors[rand.Next(0,99)];
            if (lineColor - bgColor > 100)
            {
                this.BackColor = bgColor.getColor();
            }  
        }
    }
}
