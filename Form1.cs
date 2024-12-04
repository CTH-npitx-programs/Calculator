using System;
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
        
        private void activeConfirm(int duration)
        {
            if ( tmr_ConfirmClose.Enabled == false)
            {
                MessageBox.Show("error");
                tmr_ConfirmClose.Enabled = true;
            }
            tmr_ConfirmClose.Interval = duration;
            tmr_ConfirmClose.Start();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
           if (bttnClose.Text == closeText)
            {
                bttnClose.Text = confirmText;
                activeConfirm(confirmDuration);
            } else
            {
                Application.Exit();
            }
        }
        
        private void tmr_ConfirmClose_Tick(object sender, EventArgs e)
        {
            bttnClose.Text = closeText;
            tmr_ConfirmClose.Stop();
        }
    }
}
