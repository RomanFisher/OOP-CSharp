using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections.Generic;
using System.IO;

namespace TicTacToeForm
{
    public partial class TicTacToeForm : Form
    {
       
        public TicTacToeForm()
        {

            InitializeComponent();
            MessageBox.Show("Для початку гри зареєструйтеся");
            GenerateButtons();
            onList();


        }
        decimal n;
        Button[,] buttons = new Button[3, 3];
        private string textFromFile1;
        private string textFromFile2;
        public void onList()
        {
            string pathToFile = "Winer.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                listBox1.Items.Add(line);
        }
        public void Decode()
        {
            using (FileStream fstream = File.OpenRead($"note.txt"))
            {
               
                    byte[] array1 = new byte[fstream.Length];
                    fstream.Read(array1, 0, array1.Length);
                textBox1.Text = "Гравець  з ніком ";
                textBox1.Text+= System.Text.Encoding.Default.GetString(array1);
              
               

            }
        }

        public void Winer_Write()
        {

            //using (FileStream fstream = new FileStream($"Winer.txt", FileMode.Create))
            //{

                string writePath = "Winer.txt";
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                
                    sw.WriteLine(textBox1.Text + "Переміг"+"\r\n");

                }
                //byte[] array1 = System.Text.Encoding.Default.GetBytes(textBox1.Text+" Переміг");
                //fstream.Write(array1, 0, array1.Length);
                //fstream.Close();
            //}

        }
        public void Decode1()
        {
            using (FileStream fstream = File.OpenRead($"note1.txt"))
            {
                
                
                
                    byte[] array2 = new byte[fstream.Length];
                    fstream.Read(array2, 0, array2.Length);
                textBox1.Text = "Гравець з ніком ";
                textBox1.Text += System.Text.Encoding.Default.GetString(array2);
               

            }
        }
        private void GenerateButtons()
        {

           

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Size = new Size(150, 150);
                    buttons[i, j].Location = new Point(i * 150, j * 150);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);

                    // Define button click event
                    buttons[i, j].Click += new EventHandler(button_Click);

                    // Add button in to the panel
                    panel1.Controls.Add(buttons[i, j]);
                }			 
			}
           

        }
        
        void button_Click(object sender, EventArgs e)
        {
            
                if (i == 1)
                {

                    i = 0;
                }
                if (i == 2)
                {
                    PlayerButton.Text = "O";
                    i = 0;
                }
                button3.Enabled = false;
                button3.Visible = false;
                Decode();
                // Load the clicked button into a local variable
                Button button = sender as Button;

                // Don't do anything if the block is already marked
                if (button.Text != "")
                {
                    return;
                }

                // Mark the block with current players icon
                button.Text = PlayerButton.Text;
                if (PlayerButton.Text == "X")
                {
                    button.ForeColor = Color.Green;

                }
                else
                    button.ForeColor = Color.Coral;
                TogglePlayer();
            }
      

        private void TogglePlayer()
        {
          
            CheckIfGameEnds();

            if (PlayerButton.Text == "X")
            {
                PlayerButton.Text = "O";
                Decode1();
               

            }
            else
            {
               
                PlayerButton.Text = "X";
                Decode();
                
            } 
        }
        
        private void CheckIfGameEnds()
        {
         
            List<Button> winnerButtons = new List<Button>();
            
            #region // vertically
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != PlayerButton.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[i, j]);
                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }
            #endregion            
            #region // horizontally
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[j, i].Text != PlayerButton.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[j, i]);
                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }
            #endregion            
            #region// diagonally 1 (top-left to bottom-right)
            winnerButtons = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (buttons[i, j].Text != PlayerButton.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }
            #endregion
            #region// diagonally 2 (bottom-left to top-right)
            winnerButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i, j].Text != PlayerButton.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    ShowWinner(winnerButtons);
                    return;   
                }
            }
            #endregion

            // check if all the blocks are marked
            foreach (var button in buttons)
            {
                if (button.Text == "")
                    return;
            }

            MessageBox.Show("Гра закінчилася нічиєю");
            Application.Restart();
        }

        private void ShowWinner(List<Button> winnerButtons)
        {
            // color all the winner blocks
            foreach (var button in winnerButtons)
            {
                button.BackColor = Color.Red;
            }

            MessageBox.Show("Гравець " + PlayerButton.Text + " ПЕРЕМІГ");
            Winer_Write();
            Application.Restart();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
          
            Reg reg = new Reg();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            

                int value = random.Next(1, 3);
                if (value == 1)
                {
                    MessageBox.Show("Перший ходить гравець Х");
                i = 1;
                }
                else
                {
                    MessageBox.Show("Перший ходить гравець O");
                i = 2;
                }
            button3.Enabled = false;
            button3.Visible = false;
            if (i == 2)
            {
                PlayerButton.Text = "O";
                i = 0;
            }
            else PlayerButton.Text = "X";
            panel1.Enabled = true;
        }
        

       
     
        
    }
}
