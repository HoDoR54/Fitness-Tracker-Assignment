﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Forms
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegisteration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
