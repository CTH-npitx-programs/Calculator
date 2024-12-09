﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalc : Form
    {
        const string closeText = "Close"; //original text
        const string confirmText = "Please Confirm"; //confirmation text
        const int confirmDuration = 2500;

        public frmCalc()
        {
            InitializeComponent();
            bttnClose.Text = closeText; //set button close to use the constant's text
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {

            if (bttnClose.Text == closeText ) // next name
            {
                bttnClose.Text = confirmText;
            }
            else
            {
                Application.Exit();
            } // close
            tmr_ConfirmClose.Start();
        }

        private void tmr_ConfirmClose_Tick(object sender, EventArgs e)
        {
            tmr_ConfirmClose.Stop();
            bttnClose.Text = "test";
        }
    }
}
