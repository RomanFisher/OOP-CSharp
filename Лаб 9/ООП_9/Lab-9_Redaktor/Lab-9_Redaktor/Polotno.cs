using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_9_Redaktor
{
    public partial class Polotno : UserControl
    {
        public Polotno()
        {
            InitializeComponent();
        }
        public Color ActiveColor = Color.Red;
        public string protokol = string.Empty;
        private bool doPaint = false;
        public enum Symetry     // вид симетрії
        {
            NoAxis,             // немає осі
            VerticalAxis,       // вертикальна вісь
            HorizontalAxis,     // горизонтальна вісь
            TwoAxis,            // дві осі
            CentralAxis         // центральна вісь
        }

        public Symetry symetryNumb = Symetry.NoAxis;
        public int symm = 0;

        public int CWidth, CHeight;
        private int CrossWidth = 8;

        private void AddCross(MouseEventArgs e, int x, int y)
        {
            int X = x/* / CrossWidth * CrossWidth*/;
            int Y = y/* / CrossWidth * CrossWidth*/;

            for (int p = 0; p < protokol.Length; p += 26)
                if ((X == int.Parse(protokol.Substring(p, 5))) && Y == int.Parse(protokol.Substring(p + 5, 5)))
                { protokol = protokol.Remove(p, 26); break; }
            protokol += string.Format("{0,5}{1,5}{2,4}{3,4}{4,4}{5,4}", X, Y, ActiveColor.A.ToString(), ActiveColor.R.ToString(), ActiveColor.G.ToString(), ActiveColor.B.ToString());

        }

        private void Polotno_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(ActiveColor);
            for (int x = 0; x < protokol.Length; x += 26)
            {// малюємо прямокутнички за даними протоколу
                brush.Color = Color.FromArgb(int.Parse(protokol.Substring(x + 10, 4)), int.Parse(protokol.Substring(x + 14, 4)), int.Parse(protokol.Substring(x + 18, 4)), int.Parse(protokol.Substring(x + 22, 4)));
                e.Graphics.FillRectangle(brush, int.Parse(protokol.Substring(x, 5)), int.Parse(protokol.Substring(x + 5, 5)), CrossWidth - 1, CrossWidth - 1);
            }

        }

        private void Polotno_MouseClick(object sender, MouseEventArgs e)
        {
            AddCross(e, e.X, e.Y);
            if (symetryNumb == Symetry.TwoAxis || symetryNumb == Symetry.CentralAxis)
                AddCross(e, CWidth * (CrossWidth) - e.X - 1, CHeight * CrossWidth - e.Y - 1);
            if ((symetryNumb == Symetry.VerticalAxis) || (symetryNumb == Symetry.TwoAxis))
                AddCross(e, CWidth * (CrossWidth) - e.X - 1, e.Y);
            if ((symetryNumb == Symetry.HorizontalAxis) || (symetryNumb == Symetry.TwoAxis))
                AddCross(e, e.X, CHeight * (CrossWidth) - e.Y - 1);

            Invalidate();
        }

        private void Polotno_SizeChanged(object sender, EventArgs e)
        {
            CWidth = Width / CrossWidth;
            CHeight = Height / CrossWidth;
        }

        public void Clear()
        {
            protokol = string.Empty;
            Invalidate();
        }

        private void Polotno_MouseDown(object sender, MouseEventArgs e)
        {
            doPaint = true;
        }

        private void Polotno_MouseUp(object sender, MouseEventArgs e)
        {
            doPaint = false;
        }

        private void Polotno_MouseLeave(object sender, EventArgs e)
        {
            doPaint = false;
        }

        private void Polotno_MouseMove(object sender, MouseEventArgs e)
        {
            if (doPaint)
            {
                Polotno_MouseClick(sender, e);
            }
        }

        private void Polotno_Load(object sender, EventArgs e)
        {

        }
    }
}
