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
        public frmCalc()
        {
            InitializeComponent();


        }
        bool debug = true;
        private void frmCalc_Load(object sender, EventArgs e)
        {
            lst_TextStore.Items.Clear();
            if( debug == true)
            {
                lst_TextStore.Visible = true;
            } //if debug on, see list

            string addItem(string item, bool newList)
            {
                if (newList == true)
                {
                    string empty = string.Empty;
                    lst_TextStore.Items.Add(item);
                    lst_TextStore.Items.Add(empty);
                } else
                {
                    lst_TextStore.Items.Add(item);
                }
                return lst_TextStore.Items.ToString();
            };

            string closeText = bttnClose.Text;
            string confirmClose = "Please Confirm Your Desire to Leave";

            addItem(debug.ToString(), false); //debug mode?
            addItem(closeText, true); //close text
            addItem(confirmClose, false); //confirm close
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
        

            

        }
    }
}
