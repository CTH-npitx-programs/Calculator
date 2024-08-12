using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Calculator
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();


        }
        bool debug = true;
        string confirmClose = "please confirm your desire to leave"; //custom text for confirming close
        private void frmCalc_Load(object sender, EventArgs e)
        {
            
            if( debug == true)
            {
                txt_debug.Visible = true;
            } //if debug on see list
            else {
                this.Size = new Size(816, 489);
            }// if deug off, shrink form for conscisness;

            string closeText = bttnClose.Text;
            

            addItem(debug.ToString(),false); //debug mode?
            addItem(closeText, true); //close text
            addItem(confirmClose, false); //confirm close
        }

        private string getNextName(string originalName)
        {
            if (bttnClose.Text == confirmClose)
            {
                return confirmClose;
            }
            else
            {
                return originalName;
            }
        }



        private string addItem(string item, bool newEntry)
        {
            string empty = Environment.NewLine;
            if (newEntry == true)
            {
                txt_debug.AppendText(empty);
            }
            else
            {
            }
            txt_debug.AppendText(item);
            txt_debug.AppendText(empty);
            return txt_debug.Text.ToString();
        }
        private void bttnClose_Click(object sender, EventArgs e)
        {

            

        }

        private void txt_debug_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
