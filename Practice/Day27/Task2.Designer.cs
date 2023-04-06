namespace Day27
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.FillButton = new System.Windows.Forms.Button();
            this.ReplacementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 394);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(197, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 394);
            this.listBox2.TabIndex = 1;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(12, 412);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(179, 48);
            this.FillButton.TabIndex = 2;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // ReplacementButton
            // 
            this.ReplacementButton.Location = new System.Drawing.Point(197, 412);
            this.ReplacementButton.Name = "ReplacementButton";
            this.ReplacementButton.Size = new System.Drawing.Size(179, 48);
            this.ReplacementButton.TabIndex = 3;
            this.ReplacementButton.Text = "Элементы кратные 5 и их сумма";
            this.ReplacementButton.UseVisualStyleBackColor = true;
            this.ReplacementButton.Click += new System.EventHandler(this.ReplacementButton_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 472);
            this.Controls.Add(this.ReplacementButton);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Task2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Task2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button ReplacementButton;
    }
}