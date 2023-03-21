namespace Day25
{
    partial class InputForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.number3TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sumCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(237, 196);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(99, 29);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(118, 125);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(100, 20);
            this.number1TextBox.TabIndex = 1;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(224, 125);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(100, 20);
            this.number2TextBox.TabIndex = 2;
            // 
            // number3TextBox
            // 
            this.number3TextBox.Location = new System.Drawing.Point(330, 125);
            this.number3TextBox.Name = "number3TextBox";
            this.number3TextBox.Size = new System.Drawing.Size(100, 20);
            this.number3TextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sumCheckBox);
            this.panel1.Controls.Add(this.number1TextBox);
            this.panel1.Controls.Add(this.number2TextBox);
            this.panel1.Controls.Add(this.number3TextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 315);
            this.panel1.TabIndex = 4;
            // 
            // sumCheckBox
            // 
            this.sumCheckBox.AutoSize = true;
            this.sumCheckBox.Location = new System.Drawing.Point(244, 232);
            this.sumCheckBox.Name = "sumCheckBox";
            this.sumCheckBox.Size = new System.Drawing.Size(60, 17);
            this.sumCheckBox.TabIndex = 4;
            this.sumCheckBox.Text = "Сумма";
            this.sumCheckBox.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 339);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel1);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.TextBox number3TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox sumCheckBox;
    }
}