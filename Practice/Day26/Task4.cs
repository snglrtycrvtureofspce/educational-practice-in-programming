using System;
using System.Drawing;
using System.Windows.Forms;

namespace Day26
{
    public partial class Task4 : Form
    {
        private const int ButtonSize = 50;
        private const int GridSpacing = 10;
        public Task4()
        {
            InitializeComponent();
            var gridWidth = (int)Math.Floor((double)(ClientSize.Width - GridSpacing) / (ButtonSize + GridSpacing));
            var gridHeight = (int)Math.Floor((double)(ClientSize.Height - GridSpacing) / (ButtonSize + GridSpacing));

            var startX = (ClientSize.Width - gridWidth * ButtonSize - (gridWidth - 1) * GridSpacing) / 2;
            var startY = (ClientSize.Height - gridHeight * ButtonSize - (gridHeight - 1) * GridSpacing) / 2;

            for (var row = 0; row < gridHeight; row++)
            {
                for (int col = 0; col < gridWidth; col++)
                {
                    Button button = new Button();
                    button.Size = new Size(ButtonSize, ButtonSize);
                    button.Location = new Point(startX + col * (ButtonSize + GridSpacing), startY + row * (ButtonSize + GridSpacing));
                    Controls.Add(button);
                }
            }
        }

        private void Task4_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
