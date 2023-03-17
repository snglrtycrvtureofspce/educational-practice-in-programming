namespace Day25
{
    partial class MainForm
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
            this.btn_task2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_task1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_task2
            // 
            this.btn_task2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_task2.Location = new System.Drawing.Point(457, 137);
            this.btn_task2.Name = "btn_task2";
            this.btn_task2.Size = new System.Drawing.Size(125, 77);
            this.btn_task2.TabIndex = 1;
            this.btn_task2.Text = "Задание 2";
            this.btn_task2.UseVisualStyleBackColor = true;
            this.btn_task2.Click += new System.EventHandler(this.btn_task2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_task1);
            this.panel1.Controls.Add(this.btn_task2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 2;
            // 
            // btn_task1
            // 
            this.btn_task1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_task1.Location = new System.Drawing.Point(195, 137);
            this.btn_task1.Name = "btn_task1";
            this.btn_task1.Size = new System.Drawing.Size(125, 77);
            this.btn_task1.TabIndex = 3;
            this.btn_task1.Text = "Задание 1";
            this.btn_task1.UseVisualStyleBackColor = true;
            this.btn_task1.Click += new System.EventHandler(this.btn_task1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зеневич Александр Олегович Т-091 Вариант 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_task2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_task1;
    }
}