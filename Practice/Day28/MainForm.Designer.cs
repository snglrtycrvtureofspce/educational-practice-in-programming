namespace Day28
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.МенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.МенюToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // МенюToolStripMenuItem
            // 
            this.МенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem,
            this.задание2ToolStripMenuItem,
            this.задание3ToolStripMenuItem,
            this.задание4ToolStripMenuItem,
            this.задание5ToolStripMenuItem});
            this.МенюToolStripMenuItem.Name = "МенюToolStripMenuItem";
            this.МенюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.МенюToolStripMenuItem.Text = "Меню";
            // 
            // задание1ToolStripMenuItem
            // 
            this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.задание1ToolStripMenuItem.Text = "Задание 1 (Компьютерная Графика)";
            this.задание1ToolStripMenuItem.Click += new System.EventHandler(this.задание1ToolStripMenuItem_Click);
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.задание2ToolStripMenuItem.Text = "Задание 2 (Анимация)";
            this.задание2ToolStripMenuItem.Click += new System.EventHandler(this.задание2ToolStripMenuItem_Click);
            // 
            // задание3ToolStripMenuItem
            // 
            this.задание3ToolStripMenuItem.Name = "задание3ToolStripMenuItem";
            this.задание3ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.задание3ToolStripMenuItem.Text = "Задание 3 (Графический редактор)";
            this.задание3ToolStripMenuItem.Click += new System.EventHandler(this.задание3ToolStripMenuItem_Click);
            // 
            // задание4ToolStripMenuItem
            // 
            this.задание4ToolStripMenuItem.Name = "задание4ToolStripMenuItem";
            this.задание4ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.задание4ToolStripMenuItem.Text = "Задание 4 (Методы)";
            this.задание4ToolStripMenuItem.Click += new System.EventHandler(this.задание4ToolStripMenuItem_Click);
            // 
            // задание5ToolStripMenuItem
            // 
            this.задание5ToolStripMenuItem.Name = "задание5ToolStripMenuItem";
            this.задание5ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.задание5ToolStripMenuItem.Text = "Задание 5 (Рекурсия. Таймер)";
            this.задание5ToolStripMenuItem.Click += new System.EventHandler(this.задание5ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem МенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание5ToolStripMenuItem;
    }
}

