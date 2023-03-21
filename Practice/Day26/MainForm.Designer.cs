namespace Day26
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
            this.задание1ЛинейныеАлгоритмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ЦиклыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание4КлассыОбъектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // МенюToolStripMenuItem
            // 
            this.МенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ЛинейныеАлгоритмыToolStripMenuItem,
            this.задание2ToolStripMenuItem,
            this.задание3ЦиклыToolStripMenuItem,
            this.задание4КлассыОбъектыToolStripMenuItem});
            this.МенюToolStripMenuItem.Name = "МенюToolStripMenuItem";
            this.МенюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.МенюToolStripMenuItem.Text = "Меню";
            // 
            // задание1ЛинейныеАлгоритмыToolStripMenuItem
            // 
            this.задание1ЛинейныеАлгоритмыToolStripMenuItem.Name = "задание1ЛинейныеАлгоритмыToolStripMenuItem";
            this.задание1ЛинейныеАлгоритмыToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.задание1ЛинейныеАлгоритмыToolStripMenuItem.Text = "Задание 1 (Линейные алгоритмы)";
            this.задание1ЛинейныеАлгоритмыToolStripMenuItem.Click += new System.EventHandler(this.задание1ЛинейныеАлгоритмыToolStripMenuItem_Click);
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.задание2ToolStripMenuItem.Text = "Задание 2 (Ветвление)";
            this.задание2ToolStripMenuItem.Click += new System.EventHandler(this.задание2ToolStripMenuItem_Click);
            // 
            // задание3ЦиклыToolStripMenuItem
            // 
            this.задание3ЦиклыToolStripMenuItem.Name = "задание3ЦиклыToolStripMenuItem";
            this.задание3ЦиклыToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.задание3ЦиклыToolStripMenuItem.Text = "Задание 3 (Циклы)";
            this.задание3ЦиклыToolStripMenuItem.Click += new System.EventHandler(this.задание3ЦиклыToolStripMenuItem_Click);
            // 
            // задание4КлассыОбъектыToolStripMenuItem
            // 
            this.задание4КлассыОбъектыToolStripMenuItem.Name = "задание4КлассыОбъектыToolStripMenuItem";
            this.задание4КлассыОбъектыToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.задание4КлассыОбъектыToolStripMenuItem.Text = "Задание 4 (Классы.Объекты)";
            this.задание4КлассыОбъектыToolStripMenuItem.Click += new System.EventHandler(this.задание4КлассыОбъектыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "День 26";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem МенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание3ЦиклыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание4КлассыОбъектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание1ЛинейныеАлгоритмыToolStripMenuItem;
    }
}

