
namespace Lab_9_Redaktor
{
    partial class PictureEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureEditor));
            this.SymetryBox = new System.Windows.Forms.GroupBox();
            this.RB_Horizontal = new System.Windows.Forms.RadioButton();
            this.RB_Vertical = new System.Windows.Forms.RadioButton();
            this.RB_Double = new System.Windows.Forms.RadioButton();
            this.RB_Central = new System.Windows.Forms.RadioButton();
            this.RB_NoSym = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.картинкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.savePictureDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.polotno1 = new Lab_9_Redaktor.Polotno();
            this.SymetryBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SymetryBox
            // 
            this.SymetryBox.Controls.Add(this.RB_Horizontal);
            this.SymetryBox.Controls.Add(this.RB_Vertical);
            this.SymetryBox.Controls.Add(this.RB_Double);
            this.SymetryBox.Controls.Add(this.RB_Central);
            this.SymetryBox.Controls.Add(this.RB_NoSym);
            this.SymetryBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymetryBox.Location = new System.Drawing.Point(705, 76);
            this.SymetryBox.Name = "SymetryBox";
            this.SymetryBox.Size = new System.Drawing.Size(182, 175);
            this.SymetryBox.TabIndex = 0;
            this.SymetryBox.TabStop = false;
            this.SymetryBox.Text = "SymetryBox";
            // 
            // RB_Horizontal
            // 
            this.RB_Horizontal.AutoSize = true;
            this.RB_Horizontal.Location = new System.Drawing.Point(6, 142);
            this.RB_Horizontal.Name = "RB_Horizontal";
            this.RB_Horizontal.Size = new System.Drawing.Size(218, 26);
            this.RB_Horizontal.TabIndex = 4;
            this.RB_Horizontal.TabStop = true;
            this.RB_Horizontal.Text = "Відносно горизонталі";
            this.RB_Horizontal.UseVisualStyleBackColor = true;
            this.RB_Horizontal.Click += new System.EventHandler(this.RB_Horizontal_CheckedChanged);
            // 
            // RB_Vertical
            // 
            this.RB_Vertical.AutoSize = true;
            this.RB_Vertical.Location = new System.Drawing.Point(6, 113);
            this.RB_Vertical.Name = "RB_Vertical";
            this.RB_Vertical.Size = new System.Drawing.Size(199, 26);
            this.RB_Vertical.TabIndex = 3;
            this.RB_Vertical.TabStop = true;
            this.RB_Vertical.Text = "Відносно вертикалі";
            this.RB_Vertical.UseVisualStyleBackColor = true;
            this.RB_Vertical.Click += new System.EventHandler(this.RB_Vertical_CheckedChanged);
            // 
            // RB_Double
            // 
            this.RB_Double.AutoSize = true;
            this.RB_Double.Location = new System.Drawing.Point(6, 84);
            this.RB_Double.Name = "RB_Double";
            this.RB_Double.Size = new System.Drawing.Size(196, 26);
            this.RB_Double.TabIndex = 2;
            this.RB_Double.TabStop = true;
            this.RB_Double.Text = "Відносно двух осей";
            this.RB_Double.UseVisualStyleBackColor = true;
            this.RB_Double.Click += new System.EventHandler(this.RB_Double_CheckedChanged);
            // 
            // RB_Central
            // 
            this.RB_Central.AutoSize = true;
            this.RB_Central.Location = new System.Drawing.Point(6, 55);
            this.RB_Central.Name = "RB_Central";
            this.RB_Central.Size = new System.Drawing.Size(175, 26);
            this.RB_Central.TabIndex = 1;
            this.RB_Central.TabStop = true;
            this.RB_Central.Text = "Відносно центру";
            this.RB_Central.UseVisualStyleBackColor = true;
            this.RB_Central.Click += new System.EventHandler(this.RB_Central_CheckedChanged);
            // 
            // RB_NoSym
            // 
            this.RB_NoSym.AutoSize = true;
            this.RB_NoSym.Location = new System.Drawing.Point(6, 26);
            this.RB_NoSym.Name = "RB_NoSym";
            this.RB_NoSym.Size = new System.Drawing.Size(137, 26);
            this.RB_NoSym.TabIndex = 0;
            this.RB_NoSym.TabStop = true;
            this.RB_NoSym.Text = "Без симетрії";
            this.RB_NoSym.UseVisualStyleBackColor = true;
            this.RB_NoSym.Click += new System.EventHandler(this.RB_NoSym_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.картинкаToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem3.Text = "Зберегти як...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(157, 26);
            this.toolStripMenuItem5.Text = "Файл";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.файлToolStripMenuItem1_Click);
            // 
            // картинкаToolStripMenuItem
            // 
            this.картинкаToolStripMenuItem.Name = "картинкаToolStripMenuItem";
            this.картинкаToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.картинкаToolStripMenuItem.Text = "Картинка";
            this.картинкаToolStripMenuItem.Click += new System.EventHandler(this.картинкуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(183, 26);
            this.toolStripMenuItem4.Text = "Загрузити";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.загрузитиToolStripMenuItem_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorButton.Location = new System.Drawing.Point(729, 33);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(131, 27);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.Text = "Колір";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(729, 428);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(131, 27);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Очистити";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // polotno1
            // 
            this.polotno1.BackColor = System.Drawing.Color.Gainsboro;
            this.polotno1.Location = new System.Drawing.Point(24, 36);
            this.polotno1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.polotno1.Name = "polotno1";
            this.polotno1.Size = new System.Drawing.Size(680, 422);
            this.polotno1.TabIndex = 2;
            // 
            // PictureEditor
            // 
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(893, 471);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.polotno1);
            this.Controls.Add(this.SymetryBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(911, 518);
            this.MinimumSize = new System.Drawing.Size(911, 518);
            this.Name = "PictureEditor";
            this.ShowIcon = false;
            this.Text = " Малювалка";
            this.SymetryBox.ResumeLayout(false);
            this.SymetryBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SymetryBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem картинкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Polotno polotno1;
        private System.Windows.Forms.RadioButton RB_Horizontal;
        private System.Windows.Forms.RadioButton RB_Vertical;
        private System.Windows.Forms.RadioButton RB_Double;
        private System.Windows.Forms.RadioButton RB_Central;
        private System.Windows.Forms.RadioButton RB_NoSym;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.SaveFileDialog savePictureDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

