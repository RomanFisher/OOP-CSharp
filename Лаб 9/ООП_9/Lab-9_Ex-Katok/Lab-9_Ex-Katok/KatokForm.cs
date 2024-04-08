using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9_Ex_Katok
{
    public partial class KatokForm : Form
    {
        Katok[] katok;
        public KatokForm()
        {
            InitializeComponent();
            Random random = new Random();
            Form form = Application.OpenForms["MainForm"];
            katok = new Katok[Convert.ToInt32(((MainForm)form).numericUpDown2.Value)];
            for (int i = 0; i < Convert.ToInt32(((MainForm)form).numericUpDown2.Value); i++)
            {
                katok[i] = new Katok(Convert.ToInt32(((MainForm)form).numericUpDown1.Value));
                katok[i].Parent = this;
                katok[i].Size = ClientSize;
                katok[i].Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            }

            //katok = new Katok(random.Next(3, 8));

            /*katok = new Katok(Convert.ToInt32(((MainForm)form).numericUpDown1.Value));
            katok.Parent = this;
            katok.Size = ClientSize;
            katok.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);*/
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
