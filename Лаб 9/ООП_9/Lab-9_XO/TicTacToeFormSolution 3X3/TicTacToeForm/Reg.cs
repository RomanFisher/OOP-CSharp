using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeForm
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }
        public void OnFile()
        {

            using (FileStream fstream = new FileStream($"note.txt", FileMode.Create))
            {

                byte[] array = System.Text.Encoding.Default.GetBytes(textBox1.Text+"\r\n");
                fstream.Write(array, 0, array.Length);
               
                fstream.Close();
            }

        }
        public void OnFile1()
        {

            using (FileStream fstream = new FileStream($"note1.txt", FileMode.Create))
            {

                byte[] array1 = System.Text.Encoding.Default.GetBytes(textBox2.Text);
                fstream.Write(array1, 0, array1.Length);

                fstream.Close();
            }

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            OnFile();
            OnFile1();
            if (textBox1.Text != default||textBox2.Text!=default)
            {
                this.Close();
            }
           

        }
       
    }
}
