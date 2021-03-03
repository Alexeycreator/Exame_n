namespace Examen
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.webOtobragenie = new System.Windows.Forms.WebBrowser();
            this.inputX = new System.Windows.Forms.Label();
            this.inputY = new System.Windows.Forms.Label();
            this.tbxInputX = new System.Windows.Forms.TextBox();
            this.tbxInputY = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblStatusOne = new System.Windows.Forms.Label();
            this.lblStatusTwo = new System.Windows.Forms.Label();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem1});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.информацияToolStripMenuItem.Text = "О программе";
            // 
            // информацияToolStripMenuItem1
            // 
            this.информацияToolStripMenuItem1.Name = "информацияToolStripMenuItem1";
            this.информацияToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.информацияToolStripMenuItem1.Text = "Информация";
            this.информацияToolStripMenuItem1.Click += new System.EventHandler(this.информацияToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // webOtobragenie
            // 
            this.webOtobragenie.Location = new System.Drawing.Point(0, 27);
            this.webOtobragenie.MinimumSize = new System.Drawing.Size(20, 20);
            this.webOtobragenie.Name = "webOtobragenie";
            this.webOtobragenie.Size = new System.Drawing.Size(1064, 346);
            this.webOtobragenie.TabIndex = 1;
            this.webOtobragenie.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // inputX
            // 
            this.inputX.AutoSize = true;
            this.inputX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputX.Location = new System.Drawing.Point(12, 411);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(87, 20);
            this.inputX.TabIndex = 2;
            this.inputX.Text = "Введите x";
            // 
            // inputY
            // 
            this.inputY.AutoSize = true;
            this.inputY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputY.Location = new System.Drawing.Point(12, 444);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(87, 20);
            this.inputY.TabIndex = 3;
            this.inputY.Text = "Введите y";
            // 
            // tbxInputX
            // 
            this.tbxInputX.Location = new System.Drawing.Point(105, 413);
            this.tbxInputX.Name = "tbxInputX";
            this.tbxInputX.Size = new System.Drawing.Size(102, 20);
            this.tbxInputX.TabIndex = 4;
            // 
            // tbxInputY
            // 
            this.tbxInputY.Location = new System.Drawing.Point(105, 446);
            this.tbxInputY.Name = "tbxInputY";
            this.tbxInputY.Size = new System.Drawing.Size(102, 20);
            this.tbxInputY.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOK.Location = new System.Drawing.Point(223, 440);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Проверить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblStatusOne
            // 
            this.lblStatusOne.AutoSize = true;
            this.lblStatusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatusOne.Location = new System.Drawing.Point(89, 493);
            this.lblStatusOne.Name = "lblStatusOne";
            this.lblStatusOne.Size = new System.Drawing.Size(62, 20);
            this.lblStatusOne.TabIndex = 7;
            this.lblStatusOne.Text = "Статус";
            // 
            // lblStatusTwo
            // 
            this.lblStatusTwo.AutoSize = true;
            this.lblStatusTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatusTwo.Location = new System.Drawing.Point(12, 493);
            this.lblStatusTwo.Name = "lblStatusTwo";
            this.lblStatusTwo.Size = new System.Drawing.Size(71, 20);
            this.lblStatusTwo.TabIndex = 8;
            this.lblStatusTwo.Text = "Статус -";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 376);
            this.Controls.Add(this.lblStatusTwo);
            this.Controls.Add(this.lblStatusOne);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxInputY);
            this.Controls.Add(this.tbxInputX);
            this.Controls.Add(this.inputY);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.webOtobragenie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Сайт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.WebBrowser webOtobragenie;
        private System.Windows.Forms.Label inputX;
        private System.Windows.Forms.Label inputY;
        private System.Windows.Forms.TextBox tbxInputX;
        private System.Windows.Forms.TextBox tbxInputY;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblStatusOne;
        private System.Windows.Forms.Label lblStatusTwo;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

