﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2RayW
{
    public partial class FormCoreOutput : Form
    {
        public FormCoreOutput()
        {
            InitializeComponent();
        }

        private void FormCoreOutput_Load(object sender, EventArgs e)
        {
            //textBoxOutput.Text = Program.output.ToString();
        }

        private void timerlog_Tick(object sender, EventArgs e)
        {
            textBoxOutput.Text = Program.output.ToString();
        }
    }
}
