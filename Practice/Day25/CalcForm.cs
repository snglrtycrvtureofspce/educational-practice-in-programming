﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day25
{
    public partial class CalcForm : Form
    {
        public CalcForm(double result)
        {
            InitializeComponent();
            resultLabel.Text = result.ToString();
        }
    }
}
