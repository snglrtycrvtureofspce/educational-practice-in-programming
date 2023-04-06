namespace Day27
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
            this.МенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1СтрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3МатрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание4ГрафикиФункцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.МенюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // МенюToolStripMenuItem
            // 
            this.МенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1СтрокиToolStripMenuItem,
            this.задание2ToolStripMenuItem,
            this.задание3МатрицыToolStripMenuItem,
            this.задание4ГрафикиФункцийToolStripMenuItem});
            this.МенюToolStripMenuItem.Name = "МенюToolStripMenuItem";
            this.МенюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.МенюToolStripMenuItem.Text = "Меню";
            // 
            // задание1СтрокиToolStripMenuItem
            // 
            this.задание1СтрокиToolStripMenuItem.Name = "задание1СтрокиToolStripMenuItem";
            this.задание1СтрокиToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.задание1СтрокиToolStripMenuItem.Text = "Задание 1 (Строки)";
            this.задание1СтрокиToolStripMenuItem.Click += new System.EventHandler(this.задание1СтрокиToolStripMenuItem_Click);
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.задание2ToolStripMenuItem.Text = "Задание 2 (Одномерный массив)";
            this.задание2ToolStripMenuItem.Click += new System.EventHandler(this.задание2ToolStripMenuItem_Click);
            // 
            // задание3МатрицыToolStripMenuItem
            // 
            this.задание3МатрицыToolStripMenuItem.Name = "задание3МатрицыToolStripMenuItem";
            this.задание3МатрицыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.задание3МатрицыToolStripMenuItem.Text = "Задание 3 (Матрицы)";
            this.задание3МатрицыToolStripMenuItem.Click += new System.EventHandler(this.задание3МатрицыToolStripMenuItem_Click);
            // 
            // задание4ГрафикиФункцийToolStripMenuItem
            // 
            this.задание4ГрафикиФункцийToolStripMenuItem.Name = "задание4ГрафикиФункцийToolStripMenuItem";
            this.задание4ГрафикиФункцийToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.задание4ГрафикиФункцийToolStripMenuItem.Text = "Задание 4 (Графики функций)";
            this.задание4ГрафикиФункцийToolStripMenuItem.Click += new System.EventHandler(this.задание4ГрафикиФункцийToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem МенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание1СтрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание3МатрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание4ГрафикиФункцийToolStripMenuItem;
    }
}

