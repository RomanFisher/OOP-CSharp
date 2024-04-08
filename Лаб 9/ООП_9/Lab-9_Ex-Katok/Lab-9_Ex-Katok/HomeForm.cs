using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Lab_9_Ex_Katok
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            KatokForm katokForm = new KatokForm();
            katokForm.ShowDialog();
        }
        public List<color> colors = new List<color>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("colors.json", FileMode.OpenOrCreate))
            {
                colors = JsonSerializer.Deserialize<List<color>>(fs);
            }
        }

    }
}
