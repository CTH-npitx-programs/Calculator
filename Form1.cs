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
        const string closeText = "Close App"; //original text
        const string confirmText = "Confirm Close"; //confirmation text

        public frmCalc()
        {
            InitializeComponent();
            bttnClose.Text = closeText; //set button close to use the constant's text
        }
        
        

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmr_ConfirmClose_Tick(object sender, EventArgs e)
        {

        }
    }
}
